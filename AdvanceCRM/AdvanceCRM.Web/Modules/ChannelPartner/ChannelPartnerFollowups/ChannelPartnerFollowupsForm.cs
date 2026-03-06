namespace AdvanceCRM.ChannelPartner.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;

    [FormScript("ChannelPartner.ChannelPartnerFollowups")]
    [BasedOnRow(typeof(ChannelPartnerFollowupsRow), CheckNames = true)]
    public class ChannelPartnerFollowupsForm
    {
        public String FollowupNote { get; set; }
        public String Details { get; set; }
        [DateTimeEditor]
        public DateTime FollowupDate { get; set; }
        [HalfWidth]
        [DefaultValue("1")]
        public Int32 Status { get; set; }
        [HalfWidth]
        public Int32 RepresentativeId { get; set; }
        [DateTimeEditor]
        public DateTime ClosingDate { get; set; }
        [Hidden]
        public Int32 ChannelPartnerId { get; set; }
    }
}
