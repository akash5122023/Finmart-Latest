
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class InHouseBankDialog extends Serenity.EntityDialog<InHouseBankRow, any> {
        protected getFormKey() { return InHouseBankForm.formKey; }
        protected getIdProperty() { return InHouseBankRow.idProperty; }
        protected getLocalTextPrefix() { return InHouseBankRow.localTextPrefix; }
        protected getNameProperty() { return InHouseBankRow.nameProperty; }
        protected getService() { return InHouseBankService.baseUrl; }
        protected getDeletePermission() { return InHouseBankRow.deletePermission; }
        protected getInsertPermission() { return InHouseBankRow.insertPermission; }
        protected getUpdatePermission() { return InHouseBankRow.updatePermission; }

        protected form = new InHouseBankForm(this.idPrefix);

    }
}