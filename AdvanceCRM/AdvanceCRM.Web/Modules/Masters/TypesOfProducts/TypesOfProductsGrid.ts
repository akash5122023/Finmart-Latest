
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfProductsGrid extends Serenity.EntityGrid<TypesOfProductsRow, any> {
        protected getColumnsKey() { return TypesOfProductsColumns.columnsKey; }
        protected getDialogType() { return TypesOfProductsDialog; }
        protected getIdProperty() { return TypesOfProductsRow.idProperty; }
        protected getInsertPermission() { return TypesOfProductsRow.insertPermission; }
        protected getLocalTextPrefix() { return TypesOfProductsRow.localTextPrefix; }
        protected getService() { return TypesOfProductsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}