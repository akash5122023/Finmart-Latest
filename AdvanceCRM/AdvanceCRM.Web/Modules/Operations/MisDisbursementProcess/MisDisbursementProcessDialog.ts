
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisDisbursementProcessDialog extends DialogBase<MisDisbursementProcessRow, any> {
        protected getFormKey() { return MisDisbursementProcessForm.formKey; }
        protected getIdProperty() { return MisDisbursementProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisDisbursementProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisDisbursementProcessRow.nameProperty; }
        protected getService() { return MisDisbursementProcessService.baseUrl; }
        protected getDeletePermission() { return MisDisbursementProcessRow.deletePermission; }
        protected getInsertPermission() { return MisDisbursementProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisDisbursementProcessRow.updatePermission; }

        protected form = new MisDisbursementProcessForm(this.idPrefix);

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

    }
}