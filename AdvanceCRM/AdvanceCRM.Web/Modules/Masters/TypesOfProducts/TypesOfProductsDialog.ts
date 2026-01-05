
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfProductsDialog extends Serenity.EntityDialog<TypesOfProductsRow, any> {
        protected getFormKey() { return TypesOfProductsForm.formKey; }
        protected getIdProperty() { return TypesOfProductsRow.idProperty; }
        protected getLocalTextPrefix() { return TypesOfProductsRow.localTextPrefix; }
        protected getNameProperty() { return TypesOfProductsRow.nameProperty; }
        protected getService() { return TypesOfProductsService.baseUrl; }
        protected getDeletePermission() { return TypesOfProductsRow.deletePermission; }
        protected getInsertPermission() { return TypesOfProductsRow.insertPermission; }
        protected getUpdatePermission() { return TypesOfProductsRow.updatePermission; }

        protected form = new TypesOfProductsForm(this.idPrefix);

    }
}