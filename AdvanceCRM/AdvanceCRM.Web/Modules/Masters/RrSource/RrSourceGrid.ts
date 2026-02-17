
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class RrSourceGrid extends Serenity.EntityGrid<RrSourceRow, any> {
        protected getColumnsKey() { return RrSourceColumns.columnsKey; }
        protected getDialogType() { return RrSourceDialog; }
        protected getIdProperty() { return RrSourceRow.idProperty; }
        protected getInsertPermission() { return RrSourceRow.insertPermission; }
        protected getLocalTextPrefix() { return RrSourceRow.localTextPrefix; }
        protected getService() { return RrSourceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}