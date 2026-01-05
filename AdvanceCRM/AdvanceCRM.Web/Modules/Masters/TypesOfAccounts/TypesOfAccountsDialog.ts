
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfAccountsDialog extends Serenity.EntityDialog<TypesOfAccountsRow, any> {
        protected getFormKey() { return TypesOfAccountsForm.formKey; }
        protected getIdProperty() { return TypesOfAccountsRow.idProperty; }
        protected getLocalTextPrefix() { return TypesOfAccountsRow.localTextPrefix; }
        protected getNameProperty() { return TypesOfAccountsRow.nameProperty; }
        protected getService() { return TypesOfAccountsService.baseUrl; }
        protected getDeletePermission() { return TypesOfAccountsRow.deletePermission; }
        protected getInsertPermission() { return TypesOfAccountsRow.insertPermission; }
        protected getUpdatePermission() { return TypesOfAccountsRow.updatePermission; }

        protected form = new TypesOfAccountsForm(this.idPrefix);

    }
}