
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisLogInProcessDialog extends DialogBase<MisLogInProcessRow, any> {
        protected getFormKey() { return MisLogInProcessForm.formKey; }
        protected getIdProperty() { return MisLogInProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisLogInProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisLogInProcessRow.nameProperty; }
        protected getService() { return MisLogInProcessService.baseUrl; }
        protected getDeletePermission() { return MisLogInProcessRow.deletePermission; }
        protected getInsertPermission() { return MisLogInProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisLogInProcessRow.updatePermission; }

        protected form = new MisLogInProcessForm(this.idPrefix);

    }
}