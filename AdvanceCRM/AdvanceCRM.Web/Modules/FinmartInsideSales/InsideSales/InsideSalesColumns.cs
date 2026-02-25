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

        // Channel Partner Details
        [Width(150), EditLink]
        public String ContactsName { get; set; }
        [Width(120)]
        public String ContactsPhone { get; set; }
        [Width(120)]
        public String ContactPersonName { get; set; }
        [Width(120)]
        public String ContactPersonPhone { get; set; }

        // Basic Information
        [Width(100)]
        public String MonthMonthsName { get; set; }
        [Width(140)]
        public DateTime FileReceivedDateTime { get; set; }
        [Width(120)]
        public String CompanyTypeCompanyTypeName { get; set; }
        [Width(150)]
        public String ProfileOfTheLead { get; set; }
        [Width(180)]
        public String CompanyMailId { get; set; }

        // Product / Business Details
        [Width(130)]
        public String ProductProductTypeName { get; set; }
        [Width(150)]
        public String NatureOfBusinessProfile { get; set; }
        [Width(120)]
        public String BusinessVintage { get; set; }
        [Width(130)]
        public String BusinessDetailBusinessDetailType { get; set; }
        [Width(130)]
        public String AccountTypeAccountTypeName { get; set; }

        // Loan Information
        [Width(130)]
        public String SalesLoanStatusSalesLoanStatusName { get; set; }
        [Width(100), AlignRight]
        public Decimal LoanAmount { get; set; }
        [Width(200)]
        public String Remark { get; set; }
        [Width(200)]
        public String AdditionalInformation { get; set; }
        [Width(140)]
        public String StageOfTheCaseCasesStageName { get; set; }

        // Ownership / Assignment
        [Width(120)]
        public String OwnerUsername { get; set; }
        [Width(120)]
        public String AssignedUsername { get; set; }
    }
}