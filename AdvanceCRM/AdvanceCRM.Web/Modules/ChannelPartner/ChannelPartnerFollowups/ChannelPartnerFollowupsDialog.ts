namespace AdvanceCRM.ChannelPartner {

    @Serenity.Decorators.registerClass()
    export class ChannelPartnerFollowupsDialog extends DialogBase<ChannelPartnerFollowupsRow, any> {
        protected getFormKey() { return ChannelPartnerFollowupsForm.formKey; }
        protected getIdProperty() { return ChannelPartnerFollowupsRow.idProperty; }
        protected getLocalTextPrefix() { return ChannelPartnerFollowupsRow.localTextPrefix; }
        protected getNameProperty() { return ChannelPartnerFollowupsRow.nameProperty; }
        protected getService() { return ChannelPartnerFollowupsService.baseUrl; }
        protected getDeletePermission() { return ChannelPartnerFollowupsRow.deletePermission; }
        protected getInsertPermission() { return ChannelPartnerFollowupsRow.insertPermission; }
        protected getUpdatePermission() { return ChannelPartnerFollowupsRow.updatePermission; }

        protected form = new ChannelPartnerFollowupsForm(this.idPrefix);

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
