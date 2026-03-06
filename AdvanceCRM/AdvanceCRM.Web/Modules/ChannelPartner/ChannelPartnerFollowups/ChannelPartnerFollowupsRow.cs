namespace AdvanceCRM.ChannelPartner
{
    using AdvanceCRM.Administration;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("ChannelPartner"), TableName("[dbo].[ChannelPartnerFollowups]")]
    [DisplayName("Channel Partner Followups"), InstanceName("Channel Partner Followups")]
    [ReadPermission("ChannelPartner:Read")]
    [ModifyPermission("ChannelPartner:Followups")]
    public sealed class ChannelPartnerFollowupsRow : Row<ChannelPartnerFollowupsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Followup Note"), Size(200), NotNull, QuickSearch, NameProperty]
        public String FollowupNote
        {
            get { return Fields.FollowupNote[this]; }
            set { Fields.FollowupNote[this] = value; }
        }

        [DisplayName("Details"), Size(2000), TextAreaEditor(Rows = 4)]
        public String Details
        {
            get { return Fields.Details[this]; }
            set { Fields.Details[this] = value; }
        }

        [DisplayName("Followup Date"), NotNull, DateTimeEditor(IntervalMinutes = 15, StartHour = 8)]
        public DateTime? FollowupDate
        {
            get { return Fields.FollowupDate[this]; }
            set { Fields.FollowupDate[this] = value; }
        }

        [DisplayName("Status"), NotNull, DefaultValue("1")]
        public Masters.StatusMaster? Status
        {
            get { return (Masters.StatusMaster?)Fields.Status[this]; }
            set { Fields.Status[this] = (Int32?)value; }
        }

        [DisplayName("Channel Partner"), NotNull, ForeignKey("[dbo].[ChannelPartner]", "Id"), LeftJoin("jChannelPartner"), TextualField("ChannelPartnerBankSalesManagerName")]
        public Int32? ChannelPartnerId
        {
            get { return Fields.ChannelPartnerId[this]; }
            set { Fields.ChannelPartnerId[this] = value; }
        }

        [DisplayName("Followup Done By"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jRepresentative"), TextualField("RepresentativeDisplayName")]
        [UserEditor]
        public Int32? RepresentativeId
        {
            get { return Fields.RepresentativeId[this]; }
            set { Fields.RepresentativeId[this] = value; }
        }

        [DisplayName("Closing Date")]
        public DateTime? ClosingDate
        {
            get { return Fields.ClosingDate[this]; }
            set { Fields.ClosingDate[this] = value; }
        }

        [DisplayName("Channel Partner Name"), Expression("jChannelPartner.[BankSalesManagerName]")]
        public String ChannelPartnerBankSalesManagerName
        {
            get { return Fields.ChannelPartnerBankSalesManagerName[this]; }
            set { Fields.ChannelPartnerBankSalesManagerName[this] = value; }
        }

        [DisplayName("Representative Display Name"), Expression("jRepresentative.[DisplayName]")]
        public String RepresentativeDisplayName
        {
            get { return Fields.RepresentativeDisplayName[this]; }
            set { Fields.RepresentativeDisplayName[this] = value; }
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField FollowupNote;
            public StringField Details;
            public DateTimeField FollowupDate;
            public Int32Field Status;
            public Int32Field ChannelPartnerId;
            public Int32Field RepresentativeId;
            public DateTimeField ClosingDate;
            public StringField ChannelPartnerBankSalesManagerName;
            public StringField RepresentativeDisplayName;
        }
    }
}
