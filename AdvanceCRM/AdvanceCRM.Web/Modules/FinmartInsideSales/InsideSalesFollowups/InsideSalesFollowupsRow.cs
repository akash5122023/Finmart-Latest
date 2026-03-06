namespace AdvanceCRM.FinmartInsideSales
{
    using AdvanceCRM.Administration;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("FinmartInsideSales"), TableName("[dbo].[InsideSalesFollowups]")]
    [DisplayName("Inside Sales Followups"), InstanceName("Inside Sales Followups")]
    [ReadPermission("InsideSales:Read")]
    [ModifyPermission("InsideSales:Followups")]
    public sealed class InsideSalesFollowupsRow : Row<InsideSalesFollowupsRow.RowFields>, IIdRow, INameRow
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

        [DisplayName("Inside Sales"), NotNull, ForeignKey("[dbo].[InsideSales]", "Id"), LeftJoin("jInsideSales"), TextualField("InsideSalesSrNo")]
        public Int32? InsideSalesId
        {
            get { return Fields.InsideSalesId[this]; }
            set { Fields.InsideSalesId[this] = value; }
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

        [DisplayName("Inside Sales Sr No"), Expression("jInsideSales.[SrNo]")]
        public String InsideSalesSrNo
        {
            get { return Fields.InsideSalesSrNo[this]; }
            set { Fields.InsideSalesSrNo[this] = value; }
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
            public Int32Field InsideSalesId;
            public Int32Field RepresentativeId;
            public DateTimeField ClosingDate;
            public StringField InsideSalesSrNo;
            public StringField RepresentativeDisplayName;
        }
    }
}
