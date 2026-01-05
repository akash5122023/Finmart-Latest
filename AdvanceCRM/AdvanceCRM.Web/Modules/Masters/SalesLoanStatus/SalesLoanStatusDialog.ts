
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class SalesLoanStatusDialog extends Serenity.EntityDialog<SalesLoanStatusRow, any> {
        protected getFormKey() { return SalesLoanStatusForm.formKey; }
        protected getIdProperty() { return SalesLoanStatusRow.idProperty; }
        protected getLocalTextPrefix() { return SalesLoanStatusRow.localTextPrefix; }
        protected getNameProperty() { return SalesLoanStatusRow.nameProperty; }
        protected getService() { return SalesLoanStatusService.baseUrl; }
        protected getDeletePermission() { return SalesLoanStatusRow.deletePermission; }
        protected getInsertPermission() { return SalesLoanStatusRow.insertPermission; }
        protected getUpdatePermission() { return SalesLoanStatusRow.updatePermission; }

        protected form = new SalesLoanStatusForm(this.idPrefix);

    }
}