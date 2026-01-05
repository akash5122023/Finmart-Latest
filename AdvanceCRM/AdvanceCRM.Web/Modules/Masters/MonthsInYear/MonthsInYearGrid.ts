
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MonthsInYearGrid extends Serenity.EntityGrid<MonthsInYearRow, any> {
        protected getColumnsKey() { return MonthsInYearColumns.columnsKey; }
        protected getDialogType() { return MonthsInYearDialog; }
        protected getIdProperty() { return MonthsInYearRow.idProperty; }
        protected getInsertPermission() { return MonthsInYearRow.insertPermission; }
        protected getLocalTextPrefix() { return MonthsInYearRow.localTextPrefix; }
        protected getService() { return MonthsInYearService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}