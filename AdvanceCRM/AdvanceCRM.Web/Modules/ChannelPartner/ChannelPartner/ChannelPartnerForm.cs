using AdvanceCRM.Administration;
using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.ChannelPartner.Forms
{
    [FormScript("ChannelPartner.ChannelPartner")]
    [BasedOnRow(typeof(ChannelPartnerRow), CheckNames = true)]
    public class ChannelPartnerForm
    {
        [Category("Bank Details")]
        [HalfWidth, LookupEditor(typeof(BankNameRow))]
        [DisplayName("Bank Name")]
        public Int32 BankNameId { get; set; }

        [HalfWidth, DisplayName("Bank Sales Manager Name")]
        
        public String BankSalesManagerName { get; set; }
        [Category("Loan Details")]
        [HalfWidth, LookupEditor(typeof(TypesOfProductsRow))]
        [DisplayName("Types of Product")]
        public Int32 ProductId { get; set; }
        [HalfWidth]
        [DisplayName("Loan Amount")]
        public Decimal LoanAmount { get; set; }
        //[DefaultValue("now"), ReadOnly(true)]
        [HalfWidth, DateTimeEditor]
        public DateTime LoginDate { get; set; }
        [Category("Disbursement Details")]
        [HalfWidth, LookupEditor(typeof(MisDisbursementStatusRow))]
        [DisplayName("Disbursement Status")]
        public Int32 MisDisbursementStatusId { get; set; }
        //[DefaultValue("now"), ReadOnly(true)]
        [HalfWidth, DateTimeEditor]
        public DateTime DisbursementDate { get; set; }
        [HalfWidth]
        [DisplayName("Disbursed Amount")]
        public Decimal DisbursedAmount { get; set; }
        [Category("Ownership / Assignment")]
        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Created By")]
        public Int32 OwnerId { get; set; }
    }
}