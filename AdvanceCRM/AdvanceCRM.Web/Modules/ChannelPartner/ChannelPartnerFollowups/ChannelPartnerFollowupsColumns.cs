namespace AdvanceCRM.ChannelPartner.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;

    [ColumnsScript("ChannelPartner.ChannelPartnerFollowups")]
    [BasedOnRow(typeof(ChannelPartnerFollowupsRow), CheckNames = true)]
    public class ChannelPartnerFollowupsColumns
    {
        [EditLink, Width(120)]
        public String FollowupNote { get; set; }
        public String Details { get; set; }
        [QuickFilter]
        public DateTime FollowupDate { get; set; }
        [QuickFilter]
        public Masters.StatusMaster Status { get; set; }
        [DisplayName("Followup Done By"), QuickFilter]
        public String RepresentativeDisplayName { get; set; }
        public DateTime ClosingDate { get; set; }
    }
}
