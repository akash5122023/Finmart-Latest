
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class BusinessDetailsGrid extends Serenity.EntityGrid<BusinessDetailsRow, any> {
        protected getColumnsKey() { return BusinessDetailsColumns.columnsKey; }
        protected getDialogType() { return BusinessDetailsDialog; }
        protected getIdProperty() { return BusinessDetailsRow.idProperty; }
        protected getInsertPermission() { return BusinessDetailsRow.insertPermission; }
        protected getLocalTextPrefix() { return BusinessDetailsRow.localTextPrefix; }
        protected getService() { return BusinessDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}