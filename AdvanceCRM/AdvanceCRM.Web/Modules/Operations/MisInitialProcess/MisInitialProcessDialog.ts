
namespace AdvanceCRM.Operations {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class MisInitialProcessDialog extends DialogBase<MisInitialProcessRow, any> {
        protected getFormKey() { return MisInitialProcessForm.formKey; }
        protected getIdProperty() { return MisInitialProcessRow.idProperty; }
        protected getLocalTextPrefix() { return MisInitialProcessRow.localTextPrefix; }
        protected getNameProperty() { return MisInitialProcessRow.nameProperty; }
        protected getService() { return MisInitialProcessService.baseUrl; }
        protected getDeletePermission() { return MisInitialProcessRow.deletePermission; }
        protected getInsertPermission() { return MisInitialProcessRow.insertPermission; }
        protected getUpdatePermission() { return MisInitialProcessRow.updatePermission; }

        protected form = new MisInitialProcessForm(this.idPrefix);

    }
}