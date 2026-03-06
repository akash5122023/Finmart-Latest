namespace AdvanceCRM.FinmartInsideSales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;

    [FormScript("FinmartInsideSales.InsideSalesFollowups")]
    [BasedOnRow(typeof(InsideSalesFollowupsRow), CheckNames = true)]
    public class InsideSalesFollowupsForm
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
        public Int32 InsideSalesId { get; set; }
    }
}
