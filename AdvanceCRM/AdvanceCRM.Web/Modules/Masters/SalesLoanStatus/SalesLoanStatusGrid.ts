
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class SalesLoanStatusGrid extends Serenity.EntityGrid<SalesLoanStatusRow, any> {
        protected getColumnsKey() { return SalesLoanStatusColumns.columnsKey; }
        protected getDialogType() { return SalesLoanStatusDialog; }
        protected getIdProperty() { return SalesLoanStatusRow.idProperty; }
        protected getInsertPermission() { return SalesLoanStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return SalesLoanStatusRow.localTextPrefix; }
        protected getService() { return SalesLoanStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}