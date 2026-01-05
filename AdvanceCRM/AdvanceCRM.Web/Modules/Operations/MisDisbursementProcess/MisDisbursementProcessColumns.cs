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
        public String SourceName { get; set; }
        public String CustomerName { get; set; }
        public String BankSourceOrCompanyName { get; set; }
        public String ContactPersonInTeam { get; set; }
        public String Location { get; set; }
        public String ProductProductTypeName { get; set; }
       // public DateTime DisbursementDate { get; set; }
        public String Year { get; set; }
        [LookupEditor(typeof(MonthsInYearRow))]
        public Int32 MonthId { get; set; }
        //public String MonthMonthsName { get; set; }
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32 ProductId { get; set; }
        [LookupEditor(typeof(BankNameRow))]
        public Int32 BankNameId { get; set; }
        //public String BankNameBankNames { get; set; }
        public String LoanAccountNumber { get; set; }
        [LookupEditor(typeof(PrimeEmergingRow))]
        public Int32 PrimeEmergingId { get; set; }
        //public String PrimeEmergingPrimeEmergingName { get; set; }
        [LookupEditor(typeof(MisDirectIndirectRow))]
        public Int32 MisDirectIndirectId { get; set; }
        //public String MisDirectIndirectMisDirectIndirectType { get; set; }
        //public String InhouseBankInHouseBankType { get; set; }
        [LookupEditor(typeof(MisDisbursementStatusRow))]
        public Int32 MisDisbursementStatusId { get; set; }
        //public String MisDisbursementStatusMisDisbursementStatusType { get; set; }
        public Decimal Amount { get; set; }
        public Decimal NetAmt { get; set; }
        public String EmployeeName { get; set; }
        public String ConfirmationMailTakenOrNot { get; set; }
        public String AgreementSigningPersonName { get; set; }
        public String SubInsurancePf { get; set; }
        public String OwnerUsername { get; set; }
        public String AssignedUsername { get; set; }
    }
}