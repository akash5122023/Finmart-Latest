
namespace AdvanceCRM.FinmartInsideSales {

    @Serenity.Decorators.registerClass()
        @Serenity.Decorators.panel()
    export class InsideSalesDialog extends DialogBase<InsideSalesRow, any> {
        protected getFormKey() { return InsideSalesForm.formKey; }
        protected getIdProperty() { return InsideSalesRow.idProperty; }
        protected getLocalTextPrefix() { return InsideSalesRow.localTextPrefix; }
        protected getNameProperty() { return InsideSalesRow.nameProperty; }
        protected getService() { return InsideSalesService.baseUrl; }
        protected getDeletePermission() { return InsideSalesRow.deletePermission; }
        protected getInsertPermission() { return InsideSalesRow.insertPermission; }
        protected getUpdatePermission() { return InsideSalesRow.updatePermission; }

        protected form = new InsideSalesForm(this.idPrefix);
        protected onDialogOpen() {
            super.onDialogOpen();

            if (this.isNew()) {
                this.form.MonthId.value = (new Date().getMonth() + 1).toString();
            }
            if (this.isNew()) {
                this.form.FileReceivedDateTime.value = Q.formatDate(new Date(), 'yyyy-MM-dd');
            }
        }
    }
}