
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class CasesStageDialog extends Serenity.EntityDialog<CasesStageRow, any> {
        protected getFormKey() { return CasesStageForm.formKey; }
        protected getIdProperty() { return CasesStageRow.idProperty; }
        protected getLocalTextPrefix() { return CasesStageRow.localTextPrefix; }
        protected getNameProperty() { return CasesStageRow.nameProperty; }
        protected getService() { return CasesStageService.baseUrl; }
        protected getDeletePermission() { return CasesStageRow.deletePermission; }
        protected getInsertPermission() { return CasesStageRow.insertPermission; }
        protected getUpdatePermission() { return CasesStageRow.updatePermission; }

        protected form = new CasesStageForm(this.idPrefix);

    }
}