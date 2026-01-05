
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class MisDirectIndirectDialog extends Serenity.EntityDialog<MisDirectIndirectRow, any> {
        protected getFormKey() { return MisDirectIndirectForm.formKey; }
        protected getIdProperty() { return MisDirectIndirectRow.idProperty; }
        protected getLocalTextPrefix() { return MisDirectIndirectRow.localTextPrefix; }
        protected getNameProperty() { return MisDirectIndirectRow.nameProperty; }
        protected getService() { return MisDirectIndirectService.baseUrl; }
        protected getDeletePermission() { return MisDirectIndirectRow.deletePermission; }
        protected getInsertPermission() { return MisDirectIndirectRow.insertPermission; }
        protected getUpdatePermission() { return MisDirectIndirectRow.updatePermission; }

        protected form = new MisDirectIndirectForm(this.idPrefix);

    }
}