
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisLogInProcessDialog extends DialogBase<MisLogInProcessRow, any> {
        protected getFormKey() { return MisLogInProcessForm.formKey; }
        protected getIdProperty() { return MisLogInProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisLogInProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisLogInProcessRow.nameProperty; }
        protected getService() { return MisLogInProcessService.baseUrl; }
        protected getDeletePermission() { return MisLogInProcessRow.deletePermission; }
        protected getInsertPermission() { return MisLogInProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisLogInProcessRow.updatePermission; }

        protected form = new MisLogInProcessForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // Update visibility based on which field has data
            this.updateNameFieldsVisibility();
        }

        // Show CustomerName or FirmName based on which has data
        private updateNameFieldsVisibility() {
            var customerName = this.form.CustomerName.value;
            var firmName = this.form.FirmName.value;

            // If FirmName has value -> Organization (show FirmName, hide CustomerName)
            // If CustomerName has value -> Individual (show CustomerName, hide FirmName)
            // If both empty or both filled -> show both
            if (firmName && !customerName) {
                // Organization - show FirmName only
                this.form.CustomerName.getGridField().toggle(false);
                this.form.FirmName.getGridField().toggle(true);
            } else if (customerName && !firmName) {
                // Individual - show CustomerName only
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(false);
            } else {
                // Show both if both empty or both have values
                this.form.CustomerName.getGridField().toggle(true);
                this.form.FirmName.getGridField().toggle(true);
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

            if (Authorization.hasPermission("MISLogInProcess:Move To DisbursementProcess")) {
                buttons.push({
                    title: 'To DisbursementProcess',
                    icon: 'fa fa-share-square text-blue',
                    hint: 'Move to DisbursementProcess',
                    onClick: () => {
                        MisLogInProcessService.MoveToDisbursementProcess({ //Disable if not applicable
                            Id: this.get_entityId(),
                            MailType: "Sales"
                        },
                            response => {
                                if (response.Id > 0) {
                                    Q.notifySuccess(response.Status);

                                    // Only try to open DisbursementProcess dialog if user has read permission
                                    if (Authorization.hasPermission("MISDisbursementProcess:Read")) {
                                        new Operations.MisDisbursementProcessDialog().loadByIdAndOpenDialog(response.Id);
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
    }
}