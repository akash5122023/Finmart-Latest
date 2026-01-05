
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class LogInLoanStatusGrid extends Serenity.EntityGrid<LogInLoanStatusRow, any> {
        protected getColumnsKey() { return LogInLoanStatusColumns.columnsKey; }
        protected getDialogType() { return LogInLoanStatusDialog; }
        protected getIdProperty() { return LogInLoanStatusRow.idProperty; }
        protected getInsertPermission() { return LogInLoanStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return LogInLoanStatusRow.localTextPrefix; }
        protected getService() { return LogInLoanStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}