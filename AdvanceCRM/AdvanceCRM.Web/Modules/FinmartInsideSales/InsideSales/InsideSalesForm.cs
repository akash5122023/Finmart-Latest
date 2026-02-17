using AdvanceCRM.Administration;
using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.FinmartInsideSales.Forms
{
    [FormScript("FinmartInsideSales.InsideSales")]
    [BasedOnRow(typeof(InsideSalesRow), CheckNames = true)]
    public class InsideSalesForm
    {
        [Category("Channel Partner Details")]
        [HalfWidth]
        public Int32 ContactsId { get; set; }
        [Hidden]
        public Int32 ContactsContactType { get; set; }
        [Hidden]
        public String ContactsName { get; set; }

        [Hidden]
        public String ContactsEmail { get; set; }
        [HalfWidth, ReadOnly(true), DisplayName("Contact Phone")]
        public String ContactsPhone { get; set; }
        [Hidden]
        public String ContactsWhatsapp { get; set; }
        [Hidden, ReadOnly(true)]
        public String ContactsAddress { get; set; }
        [HalfWidth, FormCssClass("line-break-sm")]
        public Int32 ContactPersonId { get; set; }
        [Hidden]
        public String ContactPersonName { get; set; }
        [ReadOnly(true), HalfWidth]
        public String ContactPersonPhone { get; set; }
        [Hidden]
        public String ContactPersonWhatsapp { get; set; }
        [Hidden]
        public String ContactPersonProject { get; set; }
        [Hidden, ReadOnly(true)]
        public String ContactPersonAddress { get; set; }
        [Category("Basic Information")]

        [HalfWidth, LookupEditor(typeof(MonthsInYearRow))]
        [DisplayName("Month")]
        public Int32 MonthId { get; set; }

        [HalfWidth, DateTimeEditor, DisplayName("File Received Date")]
        public DateTime FileReceivedDateTime { get; set; }

        //[HalfWidth, DisplayName("Customer Name")]
        //public String CustomerName { get; set; }

        //[HalfWidth, DisplayName("Company Name")]
        //public String FirmName { get; set; }

        [HalfWidth, LookupEditor(typeof(TypesOfCompaniesRow))]
        [DisplayName("Types of Companies")]
        public Int32 CompanyTypeId { get; set; }
        //[HalfWidth, LookupEditor(typeof(Profile))]

        [HalfWidth, DisplayName("Profile of the Lead")]
        public String ProfileOfTheLead { get; set; }

        //[HalfWidth, DisplayName("Contact Number")]
        //public String ContactNumber { get; set; }

        [HalfWidth, DisplayName("Company/Individual Mail ID")]
        public String CompanyMailId { get; set; }

        // -------------------- PRODUCT DETAILS --------------------
        [Category("Product / Business Details")]

        [HalfWidth, LookupEditor(typeof(TypesOfProductsRow))]
        [DisplayName("Types of Product")]
        public Int32? ProductId { get; set; }

        [HalfWidth, DisplayName("Nature of Business")]
        public String NatureOfBusinessProfile { get; set; }

        [HalfWidth, DisplayName("Business Vintage")]
        public String BusinessVintage { get; set; }

        [HalfWidth, LookupEditor(typeof(BusinessDetailsRow))]
        [DisplayName("Business Details")]
        public Int32 BusinessDetailId { get; set; }

        [HalfWidth, LookupEditor(typeof(TypesOfAccountsRow))]
        [DisplayName("Types of Accounts")]
        public Int32 AccountTypeId { get; set; }

        // -------------------- LOAN DETAILS --------------------
        [Category("Loan Information")]

        [HalfWidth, LookupEditor(typeof(SalesLoanStatusRow))]
        [DisplayName("Loan Status")]
        public Int32 SalesLoanStatusId { get; set; }

        [HalfWidth, DisplayName("Loan Amount")]
        [EditorType("LoanAmountEditor")]
        public Decimal LoanAmount { get; set; }

        [FullWidth, TextAreaEditor(Rows = 2)]
        public String Remark { get; set; }
        [FullWidth, TextAreaEditor(Rows = 2)]
        public String? AdditionalInformation { get; set; }
        [HalfWidth, LookupEditor(typeof(CasesStageRow))]
        [DisplayName("Stage of the Case")]
        public Int32 StageOfTheCaseId { get; set; }

        // -------------------- ASSIGNMENT --------------------
        [Category("Ownership / Assignment")]

        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Created By")]
        public Int32 OwnerId { get; set; }

        [HalfWidth, LookupEditor("Administration.InitialProcessUserLookup")]
        [DisplayName("Assigned To")]
        public Int32 AssignedId { get; set; }
    }
}