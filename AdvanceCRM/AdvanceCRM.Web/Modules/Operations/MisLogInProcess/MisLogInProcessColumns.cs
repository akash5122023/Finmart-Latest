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
    [ColumnsScript("Operations.MisLogInProcess")]
    [BasedOnRow(typeof(MisLogInProcessRow), CheckNames = true)]
    public class MisLogInProcessColumns
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
        [Width(140)]
        public DateTime FileReceivedDateTime { get; set; }
        [Width(120)]
        public String SourceName { get; set; }
        [Width(120)]
        public String BankNameBankNames { get; set; }
        [Width(130)]
        public String ProductProductTypeName { get; set; }

        // Customer Details
        [Width(150)]
        public String CustomerName { get; set; }
        [Width(150)]
        public String FirmName { get; set; }
        [Width(120)]
        public String ContactNumber { get; set; }
        [Width(80)]
        public Int32 CibilScore { get; set; }
        [Width(120)]
        public String PrimeEmergingPrimeEmergingName { get; set; }
        [Width(120)]
        public String Location { get; set; }
        [Width(100)]
        public String LeadStageName { get; set; }
        [Width(120)]
        public String InhouseBankInHouseBankType { get; set; }

        // Process Details
        [Width(130)]
        public String LogInLoanStatusLogInLoanStatusName { get; set; }
        [Width(200)]
        public String Remark { get; set; }
        [Width(200)]
        public String AdditionalInformation { get; set; }
        [Width(140)]
        public DateTime SystemLoginDate { get; set; }
        [Width(140)]
        public DateTime UnderwritingDate { get; set; }
        [Width(120)]
        public String SalesManager { get; set; }

        // Business Profile
        [Width(150)]
        public String NatureOfBusinessProfile { get; set; }
        [Width(100), AlignRight]
        public Decimal ToPreviousYear { get; set; }
        [Width(100), AlignRight]
        public Decimal ToLatestYear { get; set; }

        // Financial Details
        [Width(140)]
        public DateTime DisbursementDate { get; set; }
        [Width(150)]
        public String LoanAccountNumber { get; set; }

        // Ownership / Assignment
        [Width(120)]
        public String OwnerUsername { get; set; }
        [Width(120)]
        public String AssignedUsername { get; set; }
    }
}