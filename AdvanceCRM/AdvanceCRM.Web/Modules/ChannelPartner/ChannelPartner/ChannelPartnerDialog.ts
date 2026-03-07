
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

            // Try to create followups grid, but don't fail if it can't be created
            try {
                var followupsGridElement = this.byId('FollowupsGrid');
                if (followupsGridElement && followupsGridElement.length > 0) {
                    this.followupsGrid = new ChannelPartnerFollowupsGrid(followupsGridElement);
                }
            } catch (e) {
                console.warn('Could not create ChannelPartnerFollowupsGrid:', e);
            }
        }

        loadEntity(entity: ChannelPartnerRow) {
            super.loadEntity(entity);

            if (!this.isNewOrDeleted() && this.followupsGrid) {
                this.followupsGrid.channelPartnerId = entity.Id.toString();
            }
        }
    }
}
