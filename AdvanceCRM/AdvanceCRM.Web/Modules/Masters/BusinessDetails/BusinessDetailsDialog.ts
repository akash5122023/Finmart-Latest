
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class BusinessDetailsDialog extends Serenity.EntityDialog<BusinessDetailsRow, any> {
        protected getFormKey() { return BusinessDetailsForm.formKey; }
        protected getIdProperty() { return BusinessDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return BusinessDetailsRow.localTextPrefix; }
        protected getNameProperty() { return BusinessDetailsRow.nameProperty; }
        protected getService() { return BusinessDetailsService.baseUrl; }
        protected getDeletePermission() { return BusinessDetailsRow.deletePermission; }
        protected getInsertPermission() { return BusinessDetailsRow.insertPermission; }
        protected getUpdatePermission() { return BusinessDetailsRow.updatePermission; }

        protected form = new BusinessDetailsForm(this.idPrefix);

    }
}