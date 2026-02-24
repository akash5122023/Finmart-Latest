using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.ChannelPartner.Columns
{
    [ColumnsScript("ChannelPartner.ChannelPartner")]
    [BasedOnRow(typeof(ChannelPartnerRow), CheckNames = true)]
    public class ChannelPartnerColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String BankNameBankNames { get; set; }
        [EditLink]
        public String BankSalesManagerName { get; set; }
        public String ProductProductTypeName { get; set; }
        public Decimal LoanAmount { get; set; }
        public DateTime LoginDate { get; set; }
        public String MisDisbursementStatusMisDisbursementStatusType { get; set; }
        public DateTime DisbursementDate { get; set; }
        public Decimal DisbursedAmount { get; set; }
        public String OwnerUsername { get; set; }
    }
}