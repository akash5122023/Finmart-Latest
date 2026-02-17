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
    [FormScript("Operations.MisDisbursementProcess")]
    [BasedOnRow(typeof(MisDisbursementProcessRow), CheckNames = true)]
    public class MisDisbursementProcessForm
    {
        [Category("📌 General Information")]

        [HalfWidth]
        [DisplayName("Contact Person")]
        public string ContactPersonInTeam { get; set; }

        [HalfWidth]
        public Int32 Year { get; set; }

        [HalfWidth, LookupEditor(typeof(MonthsInYearRow))]
        [DisplayName("Month")]
        public Int32 MonthId { get; set; }

        [HalfWidth, LookupEditor(typeof(BankNameRow))]
        [DisplayName("Bank Name")]
        public Int32 BankNameId { get; set; }

        [HalfWidth, LookupEditor(typeof(RrSourceRow))]
        [DisplayName("Source Name")]
        public Int32 RRSourceId { get; set; }

        // ====== SECTION 2 - Applicant Information ======
        [Category("👤 Applicant Details")]

        [HalfWidth]
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }

        [HalfWidth]
        [DisplayName("Bank Source / Company Name (Eg: Truewin, Finmart, Other)")]
        public string BankSourceOrCompanyName { get; set; }
        [HalfWidth]
        public Int32 CibilScore { get; set; }       = 0;

        [HalfWidth, LookupEditor(typeof(LeadStageRow))]
        [DisplayName("Lead Stage")]
        public Int32 LeadStageId { get; set; }

        // ====== SECTION 3 - Financial Information ======
        [Category("💰 Financial Details")]
        [HalfWidth, LookupEditor(typeof(CustomerApprovalRow))]
        [DisplayName("Customer Approval")]
        public Int32 CustomerApprovalId { get; set; }
        [HalfWidth]
        public decimal Amount { get; set; }

        [HalfWidth]
        [DisplayName("Net Amount")]
        public decimal NetAmt { get; set; }

        [HalfWidth, LookupEditor(typeof(MisDisbursementStatusRow))]
        [DisplayName("Disbursement Status")]
        public Int32 MisDisbursementStatusId { get; set; }

        [HalfWidth]
        [DisplayName("Advance EMI")]
        public string AdvanceEmi { get; set; }

        [HalfWidth]
        [DisplayName("Sub / Insurance / PF")]
        public string SubInsurancePf { get; set; }

        [HalfWidth, LookupEditor(typeof(TypesOfProductsRow))]
        [DisplayName("Types of Product")]
        public Int32 ProductId { get; set; }

        [HalfWidth, LookupEditor(typeof(PrimeEmergingRow))]
        [DisplayName("Prime / Emerging")]
        public Int32 PrimeEmergingId { get; set; }

        // ====== SECTION 4 - Location & Category ======
        [Category("📍 Category & Location")]

        [HalfWidth]
        public string Location { get; set; }

        [HalfWidth, LookupEditor(typeof(MisDirectIndirectRow))]
        [DisplayName("Direct / Indirect")]
        public Int32 MisDirectIndirectId { get; set; }

        [HalfWidth]
        [DisplayName("Employee Name")]
        public string EmployeeName { get; set; }

        [HalfWidth]
        [DisplayName("Loan Account Number")]
        public string LoanAccountNumber { get; set; }

        // ====== SECTION 5 - Confirmation & Agreement ======
        [Category("📄 Agreement & Verification")]

        [HalfWidth]
        [DisplayName("Confirmation Mail Taken?")]
        public Boolean ConfirmationMailTakenOrNot { get; set; }

        [HalfWidth]
        [DisplayName("Agreement Signing Person")]
        public string AgreementSigningPersonName { get; set; }
        [FullWidth, TextAreaEditor(Rows = 2)]
        public String? AdditionalInformation { get; set; }
        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Created By")]
        public Int32 OwnerId { get; set; }

        //[HalfWidth, LookupEditor("Administration.DisbursementProcessUserLookup")]
        //[DisplayName("Assigned To")]
        //public Int32 AssignedId { get; set; }
    }
}