
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class LeadStageDialog extends Serenity.EntityDialog<LeadStageRow, any> {
        protected getFormKey() { return LeadStageForm.formKey; }
        protected getIdProperty() { return LeadStageRow.idProperty; }
        protected getLocalTextPrefix() { return LeadStageRow.localTextPrefix; }
        protected getNameProperty() { return LeadStageRow.nameProperty; }
        protected getService() { return LeadStageService.baseUrl; }
        protected getDeletePermission() { return LeadStageRow.deletePermission; }
        protected getInsertPermission() { return LeadStageRow.insertPermission; }
        protected getUpdatePermission() { return LeadStageRow.updatePermission; }

        protected form = new LeadStageForm(this.idPrefix);

    }
}