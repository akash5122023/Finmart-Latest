
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class PrimeEmergingDialog extends Serenity.EntityDialog<PrimeEmergingRow, any> {
        protected getFormKey() { return PrimeEmergingForm.formKey; }
        protected getIdProperty() { return PrimeEmergingRow.idProperty; }
        protected getLocalTextPrefix() { return PrimeEmergingRow.localTextPrefix; }
        protected getNameProperty() { return PrimeEmergingRow.nameProperty; }
        protected getService() { return PrimeEmergingService.baseUrl; }
        protected getDeletePermission() { return PrimeEmergingRow.deletePermission; }
        protected getInsertPermission() { return PrimeEmergingRow.insertPermission; }
        protected getUpdatePermission() { return PrimeEmergingRow.updatePermission; }

        protected form = new PrimeEmergingForm(this.idPrefix);

    }
}