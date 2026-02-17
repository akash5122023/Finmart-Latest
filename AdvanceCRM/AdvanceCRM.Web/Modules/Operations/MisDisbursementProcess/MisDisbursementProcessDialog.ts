
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