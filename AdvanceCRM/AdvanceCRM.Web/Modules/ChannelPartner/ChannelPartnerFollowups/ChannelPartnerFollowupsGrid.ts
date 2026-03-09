namespace AdvanceCRM.ChannelPartner {

    @Serenity.Decorators.registerClass()
    export class ChannelPartnerFollowupsGrid extends Serenity.EntityGrid<ChannelPartnerFollowupsRow, any> {
        protected getColumnsKey() { return 'ChannelPartner.ChannelPartnerFollowups'; }
        protected getDialogType() { return ChannelPartnerFollowupsDialog; }
        protected getIdProperty() { return ChannelPartnerFollowupsRow.idProperty; }
        protected getInsertPermission() { return ChannelPartnerFollowupsRow.insertPermission; }
        protected getLocalTextPrefix() { return ChannelPartnerFollowupsRow.localTextPrefix; }
        protected getService() { return ChannelPartnerFollowupsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
            this.element.find('.quick-filters-bar').toggle(false);
        }

        protected initEntityDialog(itemType, dialog) {
            super.initEntityDialog(itemType, dialog);
            Serenity.SubDialogHelper.cascade(dialog, this.element.closest('.ui-dialog'));
        }

        protected addButtonClick() {
            this.editItem({ ChannelPartnerId: this.channelPartnerId });
        }

        protected getInitialTitle() {
            return null;
        }

        protected getGridCanLoad() {
            return super.getGridCanLoad() && !!this.channelPartnerId;
        }

        private _channelPartnerId: string;

        get channelPartnerId() {
            return this._channelPartnerId;
        }

        set channelPartnerId(value: string) {
            if (this._channelPartnerId !== value) {
                this._channelPartnerId = value;
                this.setEquality('ChannelPartnerId', value);
                this.refresh();
            }
        }
    }
}
