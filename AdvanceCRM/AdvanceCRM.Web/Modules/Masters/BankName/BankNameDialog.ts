
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class BankNameDialog extends Serenity.EntityDialog<BankNameRow, any> {
        protected getFormKey() { return BankNameForm.formKey; }
        protected getIdProperty() { return BankNameRow.idProperty; }
        protected getLocalTextPrefix() { return BankNameRow.localTextPrefix; }
        protected getNameProperty() { return BankNameRow.nameProperty; }
        protected getService() { return BankNameService.baseUrl; }
        protected getDeletePermission() { return BankNameRow.deletePermission; }
        protected getInsertPermission() { return BankNameRow.insertPermission; }
        protected getUpdatePermission() { return BankNameRow.updatePermission; }

        protected form = new BankNameForm(this.idPrefix);

    }
}