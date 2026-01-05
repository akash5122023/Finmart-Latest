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
        public String SourceName { get; set; }
        public String CustomerName { get; set; }
        public String FirmName { get; set; }
        public String ContactPersonInTeam { get; set; }
        public String SalesManager { get; set; }
        public String Location { get; set; }
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32 ProductId { get; set; }

        //public String ProductProductTypeName { get; set; }
        public String NatureOfBusinessProfile { get; set; }
        public DateTime SystemLoginDate { get; set; }
        public DateTime UnderwritingDate { get; set; }
        public DateTime DisbursementDate { get; set; }
        public String Year { get; set; }
        public String MonthMonthsName { get; set; }
        [LookupEditor(typeof(BankNameRow))]
        public Int32 BankNameId { get; set; }
       // public String BankNameBankNames { get; set; }
        public String LoanAccountNumber { get; set; }
        [LookupEditor(typeof(PrimeEmergingRow))]
        public Int32 PrimeEmergingId { get; set; }
        //public String PrimeEmergingPrimeEmergingName { get; set; }
        [LookupEditor(typeof(InHouseBankRow))]
        public Int32 InhouseBankId { get; set; }
        //public String InhouseBankInHouseBankType { get; set; }
        [LookupEditor(typeof(LogInLoanStatusRow))]
        public Int32 LogInLoanStatusId { get; set; }
        //public String LogInLoanStatusLogInLoanStatusName { get; set; }
        public Decimal ToPreviousYear { get; set; }
        public Decimal ToLatestYear { get; set; }
        public String ContactNumber { get; set; }
        public String Remark { get; set; }
        public String OwnerUsername { get; set; }
        public String AssignedUsername { get; set; }
    }
}