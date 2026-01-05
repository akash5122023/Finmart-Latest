
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MisDisbursementStatusGrid extends Serenity.EntityGrid<MisDisbursementStatusRow, any> {
        protected getColumnsKey() { return MisDisbursementStatusColumns.columnsKey; }
        protected getDialogType() { return MisDisbursementStatusDialog; }
        protected getIdProperty() { return MisDisbursementStatusRow.idProperty; }
        protected getInsertPermission() { return MisDisbursementStatusRow.insertPermission; }
        protected getLocalTextPrefix() { return MisDisbursementStatusRow.localTextPrefix; }
        protected getService() { return MisDisbursementStatusService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}