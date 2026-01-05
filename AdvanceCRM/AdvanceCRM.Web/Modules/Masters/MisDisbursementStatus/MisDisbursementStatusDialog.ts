
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MisDisbursementStatusDialog extends Serenity.EntityDialog<MisDisbursementStatusRow, any> {
        protected getFormKey() { return MisDisbursementStatusForm.formKey; }
        protected getIdProperty() { return MisDisbursementStatusRow.idProperty; }
        protected getLocalTextPrefix() { return MisDisbursementStatusRow.localTextPrefix; }
        protected getNameProperty() { return MisDisbursementStatusRow.nameProperty; }
        protected getService() { return MisDisbursementStatusService.baseUrl; }
        protected getDeletePermission() { return MisDisbursementStatusRow.deletePermission; }
        protected getInsertPermission() { return MisDisbursementStatusRow.insertPermission; }
        protected getUpdatePermission() { return MisDisbursementStatusRow.updatePermission; }

        protected form = new MisDisbursementStatusForm(this.idPrefix);

    }
}