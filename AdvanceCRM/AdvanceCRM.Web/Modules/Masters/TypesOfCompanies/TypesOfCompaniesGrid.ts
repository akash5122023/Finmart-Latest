
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfCompaniesGrid extends Serenity.EntityGrid<TypesOfCompaniesRow, any> {
        protected getColumnsKey() { return TypesOfCompaniesColumns.columnsKey; }
        protected getDialogType() { return TypesOfCompaniesDialog; }
        protected getIdProperty() { return TypesOfCompaniesRow.idProperty; }
        protected getInsertPermission() { return TypesOfCompaniesRow.insertPermission; }
        protected getLocalTextPrefix() { return TypesOfCompaniesRow.localTextPrefix; }
        protected getService() { return TypesOfCompaniesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}