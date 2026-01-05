
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

    }
}