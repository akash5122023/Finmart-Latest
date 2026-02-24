
namespace AdvanceCRM.ChannelPartner {

    @Serenity.Decorators.registerClass()
    export class ChannelPartnerGrid extends GridBase<ChannelPartnerRow, any> {
        protected getColumnsKey() { return 'ChannelPartner.ChannelPartner' }
        protected getDialogType() { return ChannelPartnerDialog; }
        protected getIdProperty() { return ChannelPartnerRow.idProperty; }
        protected getInsertPermission() { return ChannelPartnerRow.insertPermission; }
        protected getLocalTextPrefix() { return ChannelPartnerRow.localTextPrefix; }
        protected getService() { return ChannelPartnerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}