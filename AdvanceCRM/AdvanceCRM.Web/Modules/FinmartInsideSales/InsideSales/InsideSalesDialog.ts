namespace AdvanceCRM.FinmartInsideSales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class InsideSalesDialog extends DialogBase<InsideSalesRow, any> {
        protected getFormKey() { return InsideSalesForm.formKey; }
        protected getIdProperty() { return InsideSalesRow.idProperty; }
        protected getLocalTextPrefix() { return InsideSalesRow.localTextPrefix; }
        protected getNameProperty() { return InsideSalesRow.nameProperty; }
        protected getService() { return InsideSalesService.baseUrl; }
        protected getDeletePermission() { return InsideSalesRow.deletePermission; }
        protected getInsertPermission() { return InsideSalesRow.insertPermission; }
        protected getUpdatePermission() { return InsideSalesRow.updatePermission; }

        protected form = new InsideSalesForm(this.idPrefix);

        constructor() {
            super();

            // Toggle CustomerName/FirmName based on ContactType when Contact is selected
            this.form.ContactsId.changeSelect2(e => {
                this.updateNameFieldsVisibility();
            });
        }

        private updateNameFieldsVisibility() {
            var contactId = Q.toId(this.form.ContactsId.value);
            var contactType: number = null;
            var contactName: string = null;
            var contactPhone: string = null;

            // Get ContactType, Name and Phone from lookup data
            if (contactId) {
                var contactsLookup = Contacts.ContactsRow.getLookup();
                var contact = contactsLookup.itemById[contactId];
                if (contact) {
                    contactType = contact.ContactType;
                    contactName = contact.Name;
                    contactPhone = contact.Phone;
                }
            }

            // Get the label elements for dynamic fields
            var contactsIdLabel = this.form.ContactsId.getGridField().find('label');
            var companyMailIdLabel = this.form.CompanyMailId.getGridField().find('label');

            // ContactType 1 = Individual, ContactType 2 = Organization
            if (contactType == 1) {
                // Individual - change labels
                contactsIdLabel.text('Customer Name');
                companyMailIdLabel.text('Individual Mail ID');

                // Individual - hide ContactPerson fields, show Contact's Phone
                this.form.ContactPersonId.getGridField().toggle(false);
                this.form.ContactPersonPhone.getGridField().toggle(false);
                this.form.ContactsPhone.getGridField().toggle(true);

                // Auto-populate ContactsPhone with Contact's Phone for Individual
                if (contactPhone) {
                    this.form.ContactsPhone.value = contactPhone;
                }
            } else if (contactType == 2) {
                // Organization - change labels
                contactsIdLabel.text('Firm Name');
                companyMailIdLabel.text('Company Mail ID');

                // Organization - show ContactPerson fields, hide Contact's Phone
                this.form.ContactPersonId.getGridField().toggle(true);
                this.form.ContactPersonPhone.getGridField().toggle(true);
                this.form.ContactsPhone.getGridField().toggle(false);
            } else {
                // No selection - reset labels
                contactsIdLabel.text('Contact');
                companyMailIdLabel.text('Company/Individual Mail ID');

                // No selection or unknown - hide all phone fields until contact is selected
                this.form.ContactPersonId.getGridField().toggle(true);
                this.form.ContactPersonPhone.getGridField().toggle(true);
                this.form.ContactsPhone.getGridField().toggle(false);
            }
        }

        protected onSaveSuccess(response: Serenity.SaveResponse): void {
            // Clear all existing notifications immediately
            $('.s-Message').remove();

            // Show our custom success message
            Q.notifySuccess("Saved Successfully");

            // Reload entity without triggering notifications
            // Use a flag or direct approach to avoid showing messages during reload
            if (response.EntityId != null) {
                // Temporarily suppress notifications during reload
                var oldNotify = Q.notifySuccess;
                Q.notifySuccess = function() {}; // Suppress

                this.loadById(response.EntityId);

                // Restore notification function
                Q.notifySuccess = oldNotify;
            }
        }

        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            if (Authorization.hasPermission("InsideSales:Move To InitialProcess")) {
                buttons.push({
                    title: 'To InitialProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to InitialProcess',
                    onClick: () => {
                        InsideSalesService.MoveToInitialProcess({ //Disable if not applicable
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifySuccess(response.Status);

                                    // Only open InitialProcess dialog if user has permission
                                    if (Authorization.hasPermission("MISInitialProcess:Read")) {
                                        new Operations.MisInitialProcessDialog().loadByIdAndOpenDialog(response.Id);
                                    }

                                    // Close current dialog
                                    this.dialogClose();
                                }
                                else
                                    Q.notifyError(response.Status)
                            }
                        );
                    }
                });
            }            
            return buttons;
        }
        protected onDialogOpen() {
            super.onDialogOpen();

            if (this.isNew()) {
                this.form.MonthId.value = (new Date().getMonth() + 1).toString();
                this.form.FileReceivedDateTime.value = Q.formatDate(new Date(), 'yyyy-MM-dd');

                // Set OwnerId to current user for new records
                if (Q.toId(this.form.OwnerId.value) < 1) {
                    this.form.OwnerId.value = Authorization.userDefinition.UserId.toString();
                }
                // For new records, show both fields until a contact is selected
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(true);
            }
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // Make OwnerId readonly when editing existing records
            if (!this.isNew()) {
                this.form.OwnerId.getGridField().find('input').prop('readonly', true);
                this.form.OwnerId.getGridField().find('.select2-container').addClass('readonly');
            }

            // Update name fields visibility based on contact type
            this.updateNameFieldsVisibility();
        }
    }
}