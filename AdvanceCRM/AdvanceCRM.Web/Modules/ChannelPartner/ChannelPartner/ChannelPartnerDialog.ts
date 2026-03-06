
namespace AdvanceCRM.ChannelPartner {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class ChannelPartnerDialog extends DialogBase<ChannelPartnerRow, any> {
        protected getFormKey() { return ChannelPartnerForm.formKey; }
        protected getIdProperty() { return ChannelPartnerRow.idProperty; }
        protected getLocalTextPrefix() { return ChannelPartnerRow.localTextPrefix; }
        protected getNameProperty() { return ChannelPartnerRow.nameProperty; }
        protected getService() { return ChannelPartnerService.baseUrl; }
        protected getDeletePermission() { return ChannelPartnerRow.deletePermission; }
        protected getInsertPermission() { return ChannelPartnerRow.insertPermission; }
        protected getUpdatePermission() { return ChannelPartnerRow.updatePermission; }

        protected form = new ChannelPartnerForm(this.idPrefix);

        private followupsGrid: ChannelPartnerFollowupsGrid;

        constructor() {
            super();

            this.followupsGrid = new ChannelPartnerFollowupsGrid(this.byId('FollowupsGrid'));
        }

        loadEntity(entity: ChannelPartnerRow) {
            super.loadEntity(entity);

            if (!this.isNewOrDeleted()) {
                this.followupsGrid.channelPartnerId = entity.Id.toString();
            }
        }
    }
}
