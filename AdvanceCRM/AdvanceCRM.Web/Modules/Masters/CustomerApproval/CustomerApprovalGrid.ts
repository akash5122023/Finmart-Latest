
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomerApprovalGrid extends Serenity.EntityGrid<CustomerApprovalRow, any> {
        protected getColumnsKey() { return CustomerApprovalColumns.columnsKey; }
        protected getDialogType() { return CustomerApprovalDialog; }
        protected getIdProperty() { return CustomerApprovalRow.idProperty; }
        protected getInsertPermission() { return CustomerApprovalRow.insertPermission; }
        protected getLocalTextPrefix() { return CustomerApprovalRow.localTextPrefix; }
        protected getService() { return CustomerApprovalService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}