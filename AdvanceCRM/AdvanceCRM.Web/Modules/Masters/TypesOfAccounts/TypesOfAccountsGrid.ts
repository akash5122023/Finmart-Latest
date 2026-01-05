
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class TypesOfAccountsGrid extends Serenity.EntityGrid<TypesOfAccountsRow, any> {
        protected getColumnsKey() { return TypesOfAccountsColumns.columnsKey; }
        protected getDialogType() { return TypesOfAccountsDialog; }
        protected getIdProperty() { return TypesOfAccountsRow.idProperty; }
        protected getInsertPermission() { return TypesOfAccountsRow.insertPermission; }
        protected getLocalTextPrefix() { return TypesOfAccountsRow.localTextPrefix; }
        protected getService() { return TypesOfAccountsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}