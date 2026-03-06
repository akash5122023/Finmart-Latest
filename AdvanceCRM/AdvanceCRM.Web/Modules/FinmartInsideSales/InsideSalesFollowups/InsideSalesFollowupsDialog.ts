namespace AdvanceCRM.FinmartInsideSales {

    @Serenity.Decorators.registerClass()
    export class InsideSalesFollowupsDialog extends DialogBase<InsideSalesFollowupsRow, any> {
        protected getFormKey() { return InsideSalesFollowupsForm.formKey; }
        protected getIdProperty() { return InsideSalesFollowupsRow.idProperty; }
        protected getLocalTextPrefix() { return InsideSalesFollowupsRow.localTextPrefix; }
        protected getNameProperty() { return InsideSalesFollowupsRow.nameProperty; }
        protected getService() { return InsideSalesFollowupsService.baseUrl; }
        protected getDeletePermission() { return InsideSalesFollowupsRow.deletePermission; }
        protected getInsertPermission() { return InsideSalesFollowupsRow.insertPermission; }
        protected getUpdatePermission() { return InsideSalesFollowupsRow.updatePermission; }

        protected form = new InsideSalesFollowupsForm(this.idPrefix);

        constructor() {
            super();

            this.form.Status.changeSelect2(e => {
                if (this.form.Status.value == "2") {
                    this.form.ClosingDate.getGridField().toggle(true);
                    this.form.ClosingDate.valueAsDate = new Date();
                }
                else {
                    this.form.ClosingDate.getGridField().toggle(false);
                }
            });
        }

        onDialogOpen() {
            super.onDialogOpen();

            if (this.form.RepresentativeId.value < "1") {
                this.form.RepresentativeId.value = Q.toId(Authorization.userDefinition.UserId);
            }
            if (this.form.Status.value != '2') {
                this.form.ClosingDate.getGridField().toggle(false);
            }
        }
    }
}
