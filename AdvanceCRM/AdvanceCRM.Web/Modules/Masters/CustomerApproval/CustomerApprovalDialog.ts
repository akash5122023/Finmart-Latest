
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class CustomerApprovalDialog extends Serenity.EntityDialog<CustomerApprovalRow, any> {
        protected getFormKey() { return CustomerApprovalForm.formKey; }
        protected getIdProperty() { return CustomerApprovalRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerApprovalRow.localTextPrefix; }
        protected getNameProperty() { return CustomerApprovalRow.nameProperty; }
        protected getService() { return CustomerApprovalService.baseUrl; }
        protected getDeletePermission() { return CustomerApprovalRow.deletePermission; }
        protected getInsertPermission() { return CustomerApprovalRow.insertPermission; }
        protected getUpdatePermission() { return CustomerApprovalRow.updatePermission; }

        protected form = new CustomerApprovalForm(this.idPrefix);

    }
}