
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfCompaniesDialog extends Serenity.EntityDialog<TypesOfCompaniesRow, any> {
        protected getFormKey() { return TypesOfCompaniesForm.formKey; }
        protected getIdProperty() { return TypesOfCompaniesRow.idProperty; }
        protected getLocalTextPrefix() { return TypesOfCompaniesRow.localTextPrefix; }
        protected getNameProperty() { return TypesOfCompaniesRow.nameProperty; }
        protected getService() { return TypesOfCompaniesService.baseUrl; }
        protected getDeletePermission() { return TypesOfCompaniesRow.deletePermission; }
        protected getInsertPermission() { return TypesOfCompaniesRow.insertPermission; }
        protected getUpdatePermission() { return TypesOfCompaniesRow.updatePermission; }

        protected form = new TypesOfCompaniesForm(this.idPrefix);

    }
}