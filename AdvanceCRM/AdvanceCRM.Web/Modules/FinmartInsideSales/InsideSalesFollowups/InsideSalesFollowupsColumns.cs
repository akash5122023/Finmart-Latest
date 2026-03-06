namespace AdvanceCRM.FinmartInsideSales.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;

    [ColumnsScript("FinmartInsideSales.InsideSalesFollowups")]
    [BasedOnRow(typeof(InsideSalesFollowupsRow), CheckNames = true)]
    public class InsideSalesFollowupsColumns
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
