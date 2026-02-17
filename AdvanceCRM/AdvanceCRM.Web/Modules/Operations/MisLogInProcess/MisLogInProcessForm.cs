using AdvanceCRM.Administration;
using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Operations.Forms
{
    [FormScript("Operations.MisLogInProcess")]
    [BasedOnRow(typeof(MisLogInProcessRow), CheckNames = true)]
    public class MisLogInProcessForm
    {
        [Category("📌 General Information")]
        [HalfWidth]
        public string ContactPersonInTeam { get; set; }

        [HalfWidth]
        public int Year { get; set; }

        [HalfWidth, LookupEditor(typeof(MonthsInYearRow))]
        [DisplayName("Month")]
        public Int32 MonthId { get; set; }

        [HalfWidth, DateTimeEditor, DisplayName("Date")]
        public DateTime FileReceivedDateTime { get; set; }

        [HalfWidth, LookupEditor(typeof(RrSourceRow))]
        [DisplayName("Source Name")]
        public Int32 RRSourceId { get; set; }

        [HalfWidth, LookupEditor(typeof(BankNameRow))]
        [DisplayName("Bank Names")]
        public Int32 BankNameId { get; set; }

        [HalfWidth, LookupEditor(typeof(TypesOfProductsRow))]
        [DisplayName("Types of Product")]
        public Int32 ProductId { get; set; }

        // ====== SECTION 2 - Customer Information ======
        [Category("👤 Customer Details")]

        [HalfWidth]
        public string CustomerName { get; set; }

        [HalfWidth]
        public string FirmName { get; set; }

        [HalfWidth]
        public string ContactNumber { get; set; }
        [HalfWidth]
        public Int32 CibilScore { get; set; }

        [HalfWidth, LookupEditor(typeof(PrimeEmergingRow))]
        [DisplayName("Prime Or Emerging")]
        public Int32 PrimeEmergingId { get; set; }

        [HalfWidth]
        public string Location { get; set; }
        [HalfWidth, LookupEditor(typeof(LeadStageRow))]
        [DisplayName("Lead Stage")]
        public Int32 LeadStageId { get; set; }

        [HalfWidth, LookupEditor(typeof(InHouseBankRow))]
        [DisplayName("InHouse Or Bank")]
        public Int32 InhouseBankId { get; set; }

        // ====== SECTION 3 - Status & Processing ======
        [Category("⚙️ Process Details")]

        [HalfWidth, LookupEditor(typeof(LogInLoanStatusRow))]
        [DisplayName("Loan Status")]
        public Int32 LogInLoanStatusId { get; set; }

        [FullWidth, TextAreaEditor(Rows = 3)]
        public string Remark { get; set; }
        [FullWidth, TextAreaEditor(Rows = 2)]
        public String? AdditionalInformation { get; set; }
        [HalfWidth, DateTimeEditor]
        public DateTime SystemLoginDate { get; set; }

        [HalfWidth, DateTimeEditor]
        public DateTime UnderwritingDate { get; set; }

        [HalfWidth]
        public string SalesManager { get; set; }

        // ====== SECTION 4 - Business Information ======
        [Category("📂 Business Profile")]

        [HalfWidth]
        public string NatureOfBusinessProfile { get; set; }

        [HalfWidth]
        public string ToPreviousYear { get; set; }

        [HalfWidth]
        public string ToLatestYear { get; set; }

        // ====== SECTION 5 - Loan Information ======
        [Category("💰 Financial Details")]

        [HalfWidth, DateTimeEditor]
        public DateTime DisbursementDate { get; set; }

        [HalfWidth]
        public string LoanAccountNumber { get; set; }

        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Created By")]
        public Int32 OwnerId { get; set; }

        [HalfWidth, LookupEditor("Administration.DisbursementProcessUserLookup")]
        [DisplayName("Assigned To")]
        public Int32 AssignedId { get; set; }
    }
}