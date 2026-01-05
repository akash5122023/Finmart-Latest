
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class LogInLoanStatusDialog extends Serenity.EntityDialog<LogInLoanStatusRow, any> {
        protected getFormKey() { return LogInLoanStatusForm.formKey; }
        protected getIdProperty() { return LogInLoanStatusRow.idProperty; }
        protected getLocalTextPrefix() { return LogInLoanStatusRow.localTextPrefix; }
        protected getNameProperty() { return LogInLoanStatusRow.nameProperty; }
        protected getService() { return LogInLoanStatusService.baseUrl; }
        protected getDeletePermission() { return LogInLoanStatusRow.deletePermission; }
        protected getInsertPermission() { return LogInLoanStatusRow.insertPermission; }
        protected getUpdatePermission() { return LogInLoanStatusRow.updatePermission; }

        protected form = new LogInLoanStatusForm(this.idPrefix);

    }
}