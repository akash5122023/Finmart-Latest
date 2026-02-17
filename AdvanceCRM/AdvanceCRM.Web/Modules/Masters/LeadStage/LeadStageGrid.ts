
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class LeadStageGrid extends Serenity.EntityGrid<LeadStageRow, any> {
        protected getColumnsKey() { return LeadStageColumns.columnsKey; }
        protected getDialogType() { return LeadStageDialog; }
        protected getIdProperty() { return LeadStageRow.idProperty; }
        protected getInsertPermission() { return LeadStageRow.insertPermission; }
        protected getLocalTextPrefix() { return LeadStageRow.localTextPrefix; }
        protected getService() { return LeadStageService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}