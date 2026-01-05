
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class CasesStageGrid extends Serenity.EntityGrid<CasesStageRow, any> {
        protected getColumnsKey() { return CasesStageColumns.columnsKey; }
        protected getDialogType() { return CasesStageDialog; }
        protected getIdProperty() { return CasesStageRow.idProperty; }
        protected getInsertPermission() { return CasesStageRow.insertPermission; }
        protected getLocalTextPrefix() { return CasesStageRow.localTextPrefix; }
        protected getService() { return CasesStageService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}