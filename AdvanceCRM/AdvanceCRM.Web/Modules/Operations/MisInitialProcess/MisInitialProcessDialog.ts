
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
                }
                // Update field visibility based on selected type
                this.updateFieldsVisibilityByCustomerType();
            });

            // When ContactsId changes, update visibility based on contact's ContactType
            this.form.ContactsId.changeSelect2(e => {
                this.updateFieldsVisibilityByContactType();
            });
        }

        // Update visibility based on CustomerType dropdown selection (Customer=1, ChannelPartner=2, etc.)
        private updateFieldsVisibilityByCustomerType() {
            var customerType = Q.toId(this.form.CustomerType.value);
            var contactsIdLabel = this.form.ContactsId.getGridField().find('label');

            // CustomerType 1 = Customer, 2 = Channel Partner
            if (customerType == 1) {
                contactsIdLabel.text('Customer');
            } else if (customerType == 2) {
                contactsIdLabel.text('Channel Partner');
            } else {
                contactsIdLabel.text('Contacts');
            }
        }

        // Update visibility based on Contact's ContactType (Individual=1, Organization=2)
        private updateFieldsVisibilityByContactType() {
            var contactId = Q.toId(this.form.ContactsId.value);
            var contactType: number = null;
            var contactPhone: string = null;

            // Get ContactType and Phone from lookup data
            if (contactId) {
                var contactsLookup = Contacts.ContactsRow.getLookup();
                var contact = contactsLookup.itemById[contactId];
                if (contact) {
                    contactType = contact.ContactType;
                    contactPhone = contact.Phone;
                }
            }

            // ContactType 1 = Individual, ContactType 2 = Organization
            if (contactType == 1) {
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
                // Organization - show FirmName, hide CustomerName
                this.form.CustomerName.getGridField().toggle(false);
                this.form.FirmName.getGridField().toggle(true);

                // Organization - show ContactPerson fields, hide Contact's Phone
                this.form.ContactPersonId.getGridField().toggle(true);
                this.form.ContactPersonPhone.getGridField().toggle(true);
                this.form.ContactsPhone.getGridField().toggle(false);
            } else {
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

            // Set CustomerType from ContactsCustomerType before form loads
            if (entity.ContactsCustomerType) {
                entity.CustomerType = entity.ContactsCustomerType;
            }

            super.loadEntity(entity);

            this.isLoadingEntity = false;
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // Update visibility based on loaded data
            this.updateFieldsVisibilityByCustomerType();
            this.updateFieldsVisibilityByContactType();

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
