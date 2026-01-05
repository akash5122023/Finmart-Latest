
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class BankNameGrid extends Serenity.EntityGrid<BankNameRow, any> {
        protected getColumnsKey() { return BankNameColumns.columnsKey; }
        protected getDialogType() { return BankNameDialog; }
        protected getIdProperty() { return BankNameRow.idProperty; }
        protected getInsertPermission() { return BankNameRow.insertPermission; }
        protected getLocalTextPrefix() { return BankNameRow.localTextPrefix; }
        protected getService() { return BankNameService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}