
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class PrimeEmergingGrid extends Serenity.EntityGrid<PrimeEmergingRow, any> {
        protected getColumnsKey() { return PrimeEmergingColumns.columnsKey; }
        protected getDialogType() { return PrimeEmergingDialog; }
        protected getIdProperty() { return PrimeEmergingRow.idProperty; }
        protected getInsertPermission() { return PrimeEmergingRow.insertPermission; }
        protected getLocalTextPrefix() { return PrimeEmergingRow.localTextPrefix; }
        protected getService() { return PrimeEmergingService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}