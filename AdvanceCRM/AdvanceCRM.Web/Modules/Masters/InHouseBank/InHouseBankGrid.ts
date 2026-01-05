
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class InHouseBankGrid extends Serenity.EntityGrid<InHouseBankRow, any> {
        protected getColumnsKey() { return InHouseBankColumns.columnsKey; }
        protected getDialogType() { return InHouseBankDialog; }
        protected getIdProperty() { return InHouseBankRow.idProperty; }
        protected getInsertPermission() { return InHouseBankRow.insertPermission; }
        protected getLocalTextPrefix() { return InHouseBankRow.localTextPrefix; }
        protected getService() { return InHouseBankService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}