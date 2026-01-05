
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MisDirectIndirectGrid extends Serenity.EntityGrid<MisDirectIndirectRow, any> {
        protected getColumnsKey() { return MisDirectIndirectColumns.columnsKey; }
        protected getDialogType() { return MisDirectIndirectDialog; }
        protected getIdProperty() { return MisDirectIndirectRow.idProperty; }
        protected getInsertPermission() { return MisDirectIndirectRow.insertPermission; }
        protected getLocalTextPrefix() { return MisDirectIndirectRow.localTextPrefix; }
        protected getService() { return MisDirectIndirectService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}