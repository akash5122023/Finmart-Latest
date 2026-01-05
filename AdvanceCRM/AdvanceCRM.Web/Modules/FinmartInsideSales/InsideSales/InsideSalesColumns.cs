using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.FinmartInsideSales.Columns
{
    [ColumnsScript("FinmartInsideSales.InsideSales")]
    [BasedOnRow(typeof(InsideSalesRow), CheckNames = true)]
    public class InsideSalesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String FirmName { get; set; }
        [LookupEditor(typeof(MonthsInYearRow))]
        public Int32 MonthId { get; set; }
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32 ProductId { get; set; }
        //public String ProductTypeName { get; set; }
        public String NatureOfBusinessProfile { get; set; }
        public String ProfileOfTheLead { get; set; }
        public String BusinessVintage { get; set; }
        [LookupEditor(typeof(BusinessDetailsRow))]
        public Int32 BusinessDetailId { get; set; }
        //public String BusinessDetailBusinessDetailType { get; set; }
        [LookupEditor(typeof(TypesOfCompaniesRow))]
        public Int32 CompanyTypeId { get; set; }
        //public String CompanyTypeCompanyTypeName { get; set; }
        [LookupEditor(typeof(TypesOfAccountsRow))]
        public Int32 AccountTypeId { get; set; }
       // public String AccountTypeAccountTypeName { get; set; }
        public DateTime FileReceivedDateTime { get; set; }
        
        public String MonthMonthsName { get; set; }
        [LookupEditor(typeof(SalesLoanStatusRow))]
        public Int32 SalesLoanStatusId { get; set; }
        //public String SalesLoanStatusSalesLoanStatusName { get; set; }
        public Decimal LoanAmount { get; set; }
       
        public String ContactNumber { get; set; }
        public String CompanyMailId { get; set; }
        /// <summary>        
        public String Remark { get; set; }
        [LookupEditor(typeof(CasesStageRow))]
        public Int32 StageOfTheCaseId { get; set; }
        //public String StageOfTheCaseCasesStageName { get; set; }
        public String OwnerUsername { get; set; }
        public String AssignedUsername { get; set; }
    }
}