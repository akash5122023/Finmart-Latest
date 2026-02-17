
namespace AdvanceCRM.Masters {

    @Serenity.Decorators.registerClass()
    export class RrSourceDialog extends Serenity.EntityDialog<RrSourceRow, any> {
        protected getFormKey() { return RrSourceForm.formKey; }
        protected getIdProperty() { return RrSourceRow.idProperty; }
        protected getLocalTextPrefix() { return RrSourceRow.localTextPrefix; }
        protected getNameProperty() { return RrSourceRow.nameProperty; }
        protected getService() { return RrSourceService.baseUrl; }
        protected getDeletePermission() { return RrSourceRow.deletePermission; }
        protected getInsertPermission() { return RrSourceRow.insertPermission; }
        protected getUpdatePermission() { return RrSourceRow.updatePermission; }

        protected form = new RrSourceForm(this.idPrefix);

    }
}