using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Operations.Columns
{
    [ColumnsScript("Operations.MisDisbursementProcess")]
    [BasedOnRow(typeof(MisDisbursementProcessRow), CheckNames = true)]
    public class MisDisbursementProcessColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }

        // General Information
        [Width(150)]
        public String ContactPersonInTeam { get; set; }
        [Width(80)]
        public String Year { get; set; }
        [Width(100)]
        public String MonthMonthsName { get; set; }
        [Width(120)]
        public String BankNameBankNames { get; set; }
        [Width(120)]
        public String SourceName { get; set; }

        // Applicant Details
        [Width(150)]
        public String CustomerName { get; set; }
        [Width(180)]
        public String BankSourceOrCompanyName { get; set; }
        [Width(80)]
        public Int32 CibilScore { get; set; }
        [Width(100)]
        public String LeadStageName { get; set; }

        // Financial Details
        [Width(130)]
        public String CustomerApprovalType { get; set; }
        [Width(100), AlignRight]
        public Decimal Amount { get; set; }
        [Width(100), AlignRight]
        public Decimal NetAmt { get; set; }
        [Width(150)]
        public String MisDisbursementStatusMisDisbursementStatusType { get; set; }
        [Width(100)]
        public String AdvanceEmi { get; set; }
        [Width(120)]
        public String SubInsurancePf { get; set; }
        [Width(130)]
        public String ProductProductTypeName { get; set; }
        [Width(120)]
        public String PrimeEmergingPrimeEmergingName { get; set; }

        // Category & Location
        [Width(120)]
        public String Location { get; set; }
        [Width(120)]
        public String MisDirectIndirectMisDirectIndirectType { get; set; }
        [Width(120)]
        public String EmployeeName { get; set; }
        [Width(150)]
        public String LoanAccountNumber { get; set; }

        // Agreement & Verification
        [Width(130)]
        public String ConfirmationMailTakenOrNot { get; set; }
        [Width(150)]
        public String AgreementSigningPersonName { get; set; }
        [Width(200)]
        public String AdditionalInformation { get; set; }

        // Ownership / Assignment
        [Width(120)]
        public String OwnerUsername { get; set; }
    }
}