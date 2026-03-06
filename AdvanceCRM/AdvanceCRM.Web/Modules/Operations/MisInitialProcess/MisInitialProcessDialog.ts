
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisInitialProcessDialog extends DialogBase<MisInitialProcessRow, any> {
        protected getFormKey() { return MisInitialProcessForm.formKey; }
        protected getIdProperty() { return MisInitialProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisInitialProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisInitialProcessRow.nameProperty; }
        protected getService() { return MisInitialProcessService.baseUrl; }
        protected getDeletePermission() { return MisInitialProcessRow.deletePermission; }
        protected getInsertPermission() { return MisInitialProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisInitialProcessRow.updatePermission; }

        protected form = new MisInitialProcessForm(this.idPrefix);
        private isLoadingEntity: boolean = false;

        constructor() {
            super();

            // When CustomerType changes, clear contacts and update visibility
            this.form.CustomerType.changeSelect2(e => {
                if (!this.isLoadingEntity) {
                    // Clear the current contacts selection when customer type changes
                    this.form.ContactsId.value = null;
                    this.form.ContactPersonId.value = null;
                    this.form.ContactsPhone.value = null;
                    this.form.ContactPersonPhone.value = null;

                    // Only auto-update SourceName when user changes CustomerType (not during load)
                    this.updateSourceNameByCustomerType();
                }
                // Update field visibility and filter contacts based on selected type
                this.updateFieldsVisibilityByCustomerType();
                this.filterContactsByCustomerType();
            });

            // When ContactsId changes, update visibility based on contact's ContactType
            this.form.ContactsId.changeSelect2(e => {
                this.updateFieldsVisibilityByContactType();
            });
        }

        // Filter Contacts dropdown based on CustomerType selection
        private filterContactsByCustomerType() {
            var customerType = Q.toId(this.form.CustomerType.value);
            var contactsEditor = this.form.ContactsId as any;

            // Apply cascade filter based on CustomerType
            if (customerType) {
                contactsEditor.cascadeValue = customerType;
                contactsEditor.cascadeField = 'CustomerType';
            } else {
                // Clear filter if no CustomerType selected
                contactsEditor.cascadeValue = null;
                contactsEditor.cascadeField = null;
            }
        }

        // Auto-update SourceName (RRSourceId) based on CustomerType selection
        private updateSourceNameByCustomerType() {
            var customerType = Q.toId(this.form.CustomerType.value);

            if (!customerType) {
                this.form.RRSourceId.value = null;
                return;
            }

            // CustomerType: 1 = Customer, 2 = Vendor, 3 = ChannelPartner, 4 = Referrer
            // Map CustomerType to RRSourceId directly
            var sourceIdMap: { [key: number]: number } = {
                1: 1,  // Customer -> RRSource Id 1
                2: 2,  // Vendor -> RRSource Id 2
                3: 3,  // ChannelPartner -> RRSource Id 3
                4: 4   // Referrer -> RRSource Id 4
            };

            var targetSourceId = sourceIdMap[customerType];
            if (targetSourceId) {
                this.form.RRSourceId.value = targetSourceId.toString();
            }
        }

        // Update visibility based on CustomerType dropdown selection (Customer=1, Vendor=2, ChannelPartner=3)
        private updateFieldsVisibilityByCustomerType() {
            var contactId = Q.toId(this.form.ContactsId.value);
            var customerType = Q.toId(this.form.CustomerType.value);
            var contactsIdLabel = this.form.ContactsId.getGridField().find('label');

            // Set label based on CustomerType when no contact is selected
            // CustomerType: 1 = Customer, 2 = Vendor, 3 = ChannelPartner
            if (customerType == 3) {
                // ChannelPartner - change label to CP Name
                contactsIdLabel.text('CP Name');
                // ChannelPartner - hide both CustomerName and FirmName until contact is selected
                // The actual visibility will be determined by ContactType (Individual/Organization)
                this.form.CustomerName.getGridField().toggle(false);
                this.form.FirmName.getGridField().toggle(false);
            } else if (customerType == 1) {
                contactsIdLabel.text('Customer');
                // Customer - show CustomerName, hide FirmName
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(false);
            } else if (customerType == 2) {
                contactsIdLabel.text('Vendor');
                // Vendor - show CustomerName, hide FirmName
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(false);
            } else {
                contactsIdLabel.text('Contacts');
            }
        }

        // Update visibility based on Contact's ContactType (Individual=1, Organization=2)
        // Also considers CustomerType for ChannelPartner label
        private updateFieldsVisibilityByContactType() {
            var contactId = Q.toId(this.form.ContactsId.value);
            var customerType = Q.toId(this.form.CustomerType.value);
            var contactType: number = null;
            var contactCustomerType: number = null;
            var contactPhone: string = null;

            // Get ContactType, CustomerType and Phone from lookup data
            if (contactId) {
                var contactsLookup = Contacts.ContactsRow.getLookup();
                var contact = contactsLookup.itemById[contactId];
                if (contact) {
                    contactType = contact.ContactType;
                    contactCustomerType = contact.CustomerType;
                    contactPhone = contact.Phone;
                }
            }

            // Get the label element for ContactsId
            var contactsIdLabel = this.form.ContactsId.getGridField().find('label');

            // Check if CustomerType is ChannelPartner (3) - this takes priority
            if (customerType == 3 || contactCustomerType == 3) {
                // ChannelPartner - change label to CP Name
                contactsIdLabel.text('CP Name');

                // ChannelPartner - check ContactType to show CustomerName or FirmName
                // ContactType 1 = Individual, ContactType 2 = Organization
                if (contactType == 1) {
                    // Individual - show CustomerName, hide FirmName
                    this.form.CustomerName.getGridField().toggle(true);
                    this.form.FirmName.getGridField().toggle(false);
                } else if (contactType == 2) {
                    // Organization - show FirmName, hide CustomerName
                    this.form.CustomerName.getGridField().toggle(false);
                    this.form.FirmName.getGridField().toggle(true);
                } else {
                    // No ContactType selected yet - hide both until contact is selected
                    this.form.CustomerName.getGridField().toggle(false);
                    this.form.FirmName.getGridField().toggle(false);
                }

                // Hide ContactPerson fields for ChannelPartner
                this.form.ContactPersonId.getGridField().toggle(false);
                this.form.ContactPersonPhone.getGridField().toggle(false);
                this.form.ContactsPhone.getGridField().toggle(true);

                // Auto-populate ContactsPhone with Contact's Phone for ChannelPartner
                if (contactPhone) {
                    this.form.ContactsPhone.value = contactPhone;
                }
            }
            // ContactType 1 = Individual, ContactType 2 = Organization
            else if (contactType == 1) {
                // Individual - change label to Customer Name
                contactsIdLabel.text('Customer Name');

                // Individual - show CustomerName, hide FirmName
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(false);

                // Individual - hide ContactPerson fields, show Contact's Phone
                this.form.ContactPersonId.getGridField().toggle(false);
                this.form.ContactPersonPhone.getGridField().toggle(false);
                this.form.ContactsPhone.getGridField().toggle(true);

                // Auto-populate ContactsPhone with Contact's Phone for Individual
                if (contactPhone) {
                    this.form.ContactsPhone.value = contactPhone;
                }
            } else if (contactType == 2) {
                // Organization - change label to Firm Name
                contactsIdLabel.text('Firm Name');

                // Organization - show FirmName, hide CustomerName
                this.form.CustomerName.getGridField().toggle(false);
                this.form.FirmName.getGridField().toggle(true);

                // Organization - show ContactPerson fields, hide Contact's Phone
                this.form.ContactPersonId.getGridField().toggle(true);
                this.form.ContactPersonPhone.getGridField().toggle(true);
                this.form.ContactsPhone.getGridField().toggle(false);
            } else {
                // No selection - reset label based on CustomerType or default
                if (customerType == 3) {
                    contactsIdLabel.text('CP Name');
                } else if (customerType == 1) {
                    contactsIdLabel.text('Customer');
                } else if (customerType == 2) {
                    contactsIdLabel.text('Vendor');
                } else {
                    contactsIdLabel.text('Contacts');
                }

                // No selection - show both CustomerName and FirmName
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(true);

                // No selection - show ContactPerson fields by default
                this.form.ContactPersonId.getGridField().toggle(true);
                this.form.ContactPersonPhone.getGridField().toggle(true);
                this.form.ContactsPhone.getGridField().toggle(false);
            }
        }

        // Override loadEntity to set flag BEFORE form is populated
        protected loadEntity(entity: MisInitialProcessRow) {
            this.isLoadingEntity = true;

            // For existing records with ContactsId, get the CustomerType from the contact
            // This ensures the CustomerType dropdown shows the correct value
            if (entity.ContactsId && entity.ContactsCustomerType) {
                entity.CustomerType = entity.ContactsCustomerType;
            }

            // IMPORTANT: Clear any cascade filter before loading to ensure ContactsId displays
            var contactsEditor = this.form.ContactsId as any;
            contactsEditor.cascadeValue = null;
            contactsEditor.cascadeField = null;

            super.loadEntity(entity);

            this.isLoadingEntity = false;
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // Update visibility based on loaded data
            this.updateFieldsVisibilityByCustomerType();
            this.updateFieldsVisibilityByContactType();

            // Only update SourceName for new records (not when editing existing ones)
            // Existing records already have RRSourceId set from the database
            if (this.isNew()) {
                this.updateSourceNameByCustomerType();
            }

            // Make OwnerId readonly when editing existing records
            if (!this.isNew()) {
                this.form.OwnerId.getGridField().find('input').prop('readonly', true);
                this.form.OwnerId.getGridField().find('.select2-container').addClass('readonly');
            }
        }

        protected onDialogOpen() {
            super.onDialogOpen();

            if (this.isNew()) {
                // Set default values for new records
                this.form.QueriesGivenTime.value = Q.formatDate(new Date(), 'yyyy-MM-ddTHH:mm');

                // Set OwnerId to current user for new records
                if (Q.toId(this.form.OwnerId.value) < 1) {
                    this.form.OwnerId.value = Authorization.userDefinition.UserId.toString();
                }
            }
        }

        protected onSaveSuccess(response: Serenity.SaveResponse): void {
            $('.s-Message').remove();
            Q.notifySuccess("Saved Successfully");

            if (response.EntityId != null) {
                var oldNotify = Q.notifySuccess;
                Q.notifySuccess = function() {};
                this.loadById(response.EntityId);
                Q.notifySuccess = oldNotify;
            }
        }

        protected getToolbarButtons() {
            var buttons = super.getToolbarButtons();

            if (Authorization.hasPermission("MISInitialProcess:Move To LogInProcess")) {
                buttons.push({
                    title: 'To LogInProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to LogInProcess',
                    onClick: () => {
                        MisInitialProcessService.MoveToLogInProcess({
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifySuccess(response.Status);

                                    if (Authorization.hasPermission("MISLogInProcess:Read")) {
                                        new Operations.MisLogInProcessDialog().loadByIdAndOpenDialog(response.Id);
                                    }

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
    }
}
