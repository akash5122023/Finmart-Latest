using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.FinmartInsideSales
{
    [ConnectionKey("Default"), Module("FinmartInsideSales"), TableName("[dbo].[InsideSales]")]
    [DisplayName("Inside Sales"), InstanceName("Inside Sales")]
    [ReadPermission("InsideSales:Read")]
    [InsertPermission("InsideSales:Insert")]
    [UpdatePermission("InsideSales:Update")]
    [DeletePermission("InsideSales:Delete")]
    [LookupScript("FinmartInsideSales.InsideSales", Permission = "?")]
    public sealed class InsideSalesRow : Row<InsideSalesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Sr No"), Size(50), QuickSearch, NameProperty]
        public String SrNo
        {
            get => fields.SrNo[this];
            set => fields.SrNo[this] = value;
        }

        [DisplayName("Source Name"), Size(200)]
        public String SourceName
        {
            get => fields.SourceName[this];
            set => fields.SourceName[this] = value;
        }

        [DisplayName("Customer Name"), Size(200)]
        public String CustomerName
        {
            get => fields.CustomerName[this];
            set => fields.CustomerName[this] = value;
        }

        [DisplayName("Firm Name"), Size(200)]
        public String FirmName
        {
            get => fields.FirmName[this];
            set => fields.FirmName[this] = value;
        }

        [DisplayName("Bank Source Or Company Name"), Size(200)]
        public String BankSourceOrCompanyName
        {
            get => fields.BankSourceOrCompanyName[this];
            set => fields.BankSourceOrCompanyName[this] = value;
        }

        [DisplayName("File Handled By"), Size(150)]
        public String FileHandledBy
        {
            get => fields.FileHandledBy[this];
            set => fields.FileHandledBy[this] = value;
        }

        [DisplayName("Contact Person In Team"), Size(150)]
        public String ContactPersonInTeam
        {
            get => fields.ContactPersonInTeam[this];
            set => fields.ContactPersonInTeam[this] = value;
        }

        [DisplayName("Sales Manager"), Size(150)]
        public String SalesManager
        {
            get => fields.SalesManager[this];
            set => fields.SalesManager[this] = value;
        }

        [DisplayName("Location"), Size(150)]
        public String Location
        {
            get => fields.Location[this];
            set => fields.Location[this] = value;
        }

        //[DisplayName("Product"), ForeignKey("[dbo].[TypesOfProducts]", "Id"), LeftJoin("jProduct"), TextualField("ProductProductTypeName")]
        //public Int32? ProductId
        //{
        //    get => fields.ProductId[this];
        //    set => fields.ProductId[this] = value;
        //}
        [DisplayName("Products"), ForeignKey("[dbo].[TypesofProducts]", "Id"), LeftJoin("jTypesofProducts"), TextualField("ProductTypeName"), QuickFilter]
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }
        [DisplayName("Requirement"), Size(500)]
        public String Requirement
        {
            get => fields.Requirement[this];
            set => fields.Requirement[this] = value;
        }

        [DisplayName("Nature Of Business Profile"), Size(500)]
        public String NatureOfBusinessProfile
        {
            get => fields.NatureOfBusinessProfile[this];
            set => fields.NatureOfBusinessProfile[this] = value;
        }

        [DisplayName("Profile Of The Lead"), Size(500)]
        public String ProfileOfTheLead
        {
            get => fields.ProfileOfTheLead[this];
            set => fields.ProfileOfTheLead[this] = value;
        }

        [DisplayName("Business Vintage"), Size(100)]
        public String BusinessVintage
        {
            get => fields.BusinessVintage[this];
            set => fields.BusinessVintage[this] = value;
        }

        //[DisplayName("Business Detail"), ForeignKey("[dbo].[BusinessDetails]", "Id"), LeftJoin("jBusinessDetail"), TextualField("BusinessDetailBusinessDetailType")]
        //public Int32? BusinessDetailId
        //{
        //    get => fields.BusinessDetailId[this];
        //    set => fields.BusinessDetailId[this] = value;
        //}
        [DisplayName("Business Detail"), ForeignKey("[dbo].[BusinessDetails]", "Id"), LeftJoin("jBusinessDetail"), TextualField("BusinessDetailType"), QuickFilter]
        [LookupEditor(typeof(BusinessDetailsRow))]
        public Int32? BusinessDetailId
        {
            get => fields.BusinessDetailId[this];
            set => fields.BusinessDetailId[this] = value;
        }
        //[DisplayName("Company Type"), ForeignKey("[dbo].[TypesOfCompanies]", "Id"), LeftJoin("jCompanyType"), TextualField("CompanyTypeCompanyTypeName")]
        //public Int32? CompanyTypeId
        //{
        //    get => fields.CompanyTypeId[this];
        //    set => fields.CompanyTypeId[this] = value;
        //}
        [DisplayName("Company Type"), ForeignKey("[dbo].[TypesOfCompanies]", "Id"), LeftJoin("jTypesOfCompanies"), TextualField("CompanyTypeName"), QuickFilter]
        [LookupEditor(typeof(TypesOfCompaniesRow))]
        public Int32? CompanyTypeId
        {
            get { return Fields.CompanyTypeId[this]; }
            set { Fields.CompanyTypeId[this] = value; }
        }
        //[DisplayName("Account Type"), ForeignKey("[dbo].[TypesOfAccounts]", "Id"), LeftJoin("jAccountType"), TextualField("AccountTypeAccountTypeName")]
        //public Int32? AccountTypeId
        //{
        //    get => fields.AccountTypeId[this];
        //    set => fields.AccountTypeId[this] = value;
        //}
        [DisplayName("Account Type"), ForeignKey("[dbo].[TypesOfAccounts]", "Id"), LeftJoin("jTypesOfAccounts"), TextualField("AccountTypeName"), QuickFilter]
        [LookupEditor(typeof(TypesOfAccountsRow))]
        public Int32? AccountTypeId
        {
            get => fields.AccountTypeId[this];
            set => fields.AccountTypeId[this] = value;
        }
        [DisplayName("File Received Date Time")]
        public DateTime? FileReceivedDateTime
        {
            get => fields.FileReceivedDateTime[this];
            set => fields.FileReceivedDateTime[this] = value;
        }

        [DisplayName("Queries Given Time")]
        public DateTime? QueriesGivenTime
        {
            get => fields.QueriesGivenTime[this];
            set => fields.QueriesGivenTime[this] = value;
        }

        [DisplayName("File Completion Date Time")]
        public DateTime? FileCompletionDateTime
        {
            get => fields.FileCompletionDateTime[this];
            set => fields.FileCompletionDateTime[this] = value;
        }

        [DisplayName("System Login Date")]
        public DateTime? SystemLoginDate
        {
            get => fields.SystemLoginDate[this];
            set => fields.SystemLoginDate[this] = value;
        }

        [DisplayName("Underwriting Date")]
        public DateTime? UnderwritingDate
        {
            get => fields.UnderwritingDate[this];
            set => fields.UnderwritingDate[this] = value;
        }

        [DisplayName("Disbursement Date")]
        public DateTime? DisbursementDate
        {
            get => fields.DisbursementDate[this];
            set => fields.DisbursementDate[this] = value;
        }

        [DisplayName("Year"), Size(10)]
        public String Year
        {
            get => fields.Year[this];
            set => fields.Year[this] = value;
        }

        [DisplayName("Month"), ForeignKey("[dbo].[MonthsInYear]", "Id"), LeftJoin("jMonthsInYear"), TextualField("MonthMonthsName")]
        [LookupEditor(typeof(MonthsInYearRow))]
        public Int32? MonthId
        {
            get => fields.MonthId[this];
            set => fields.MonthId[this] = value;
        }

        [DisplayName("Bank Name"), ForeignKey("[dbo].[BankName]", "Id"), LeftJoin("jBankName"), TextualField("BankNameBankNames")]
        public Int32? BankNameId
        {
            get => fields.BankNameId[this];
            set => fields.BankNameId[this] = value;
        }

        [DisplayName("Loan Account Number"), Size(200)]
        public String LoanAccountNumber
        {
            get => fields.LoanAccountNumber[this];
            set => fields.LoanAccountNumber[this] = value;
        }

        [DisplayName("Prime Emerging"), ForeignKey("[dbo].[PrimeEmerging]", "Id"), LeftJoin("jPrimeEmerging"), TextualField("PrimeEmergingPrimeEmergingName")]
        [LookupEditor(typeof(PrimeEmergingRow))]
        public Int32? PrimeEmergingId
        {
            get => fields.PrimeEmergingId[this];
            set => fields.PrimeEmergingId[this] = value;
        }

        
        [DisplayName("Mis Direct Indirect"), Column("MISDirectIndirectId"), ForeignKey("[dbo].[MISDirectIndirect]", "Id"), LeftJoin("jMisDirectIndirect"), TextualField("MisDirectIndirectMisDirectIndirectType")]
        [LookupEditor(typeof(MisDirectIndirectRow))]
        public Int32? MisDirectIndirectId
        {
            get => fields.MisDirectIndirectId[this];
            set => fields.MisDirectIndirectId[this] = value;
        }

        
        [DisplayName("Inhouse Bank"), ForeignKey("[dbo].[InHouseBank]", "Id"), LeftJoin("jInhouseBank"), TextualField("InhouseBankInHouseBankType")]
        [LookupEditor(typeof(InHouseBankRow))]
        public Int32? InhouseBankId
        {
            get => fields.InhouseBankId[this];
            set => fields.InhouseBankId[this] = value;
        }

        [DisplayName("Loan Amount"), Size(19), Scale(5)]
        public Decimal? LoanAmount
        {
            get => fields.LoanAmount[this];
            set => fields.LoanAmount[this] = value;
        }

        [DisplayName("Amount"), Size(19), Scale(5)]
        public Decimal? Amount
        {
            get => fields.Amount[this];
            set => fields.Amount[this] = value;
        }

        [DisplayName("Net Amt"), Size(19), Scale(5)]
        public Decimal? NetAmt
        {
            get => fields.NetAmt[this];
            set => fields.NetAmt[this] = value;
        }

        [DisplayName("Advance Emi"), Column("AdvanceEMI"), Size(19), Scale(5)]
        public Decimal? AdvanceEmi
        {
            get => fields.AdvanceEmi[this];
            set => fields.AdvanceEmi[this] = value;
        }

        [DisplayName("To Previous Year"), Column("TOPreviousYear"), Size(19), Scale(5)]
        public Decimal? ToPreviousYear
        {
            get => fields.ToPreviousYear[this];
            set => fields.ToPreviousYear[this] = value;
        }

        [DisplayName("To Latest Year"), Column("TOLatestYear"), Size(19), Scale(5)]
        public Decimal? ToLatestYear
        {
            get => fields.ToLatestYear[this];
            set => fields.ToLatestYear[this] = value;
        }

        [DisplayName("Contact Number"), Size(50)]
        public String ContactNumber
        {
            get => fields.ContactNumber[this];
            set => fields.ContactNumber[this] = value;
        }

        [DisplayName("Company Mail Id"), Size(200)]
        public String CompanyMailId
        {
            get => fields.CompanyMailId[this];
            set => fields.CompanyMailId[this] = value;
        }

        [DisplayName("Employee Name"), Size(150)]
        public String EmployeeName
        {
            get => fields.EmployeeName[this];
            set => fields.EmployeeName[this] = value;
        }

        [DisplayName("Confirmation Mail Taken Or Not"), Size(10)]
        public String ConfirmationMailTakenOrNot
        {
            get => fields.ConfirmationMailTakenOrNot[this];
            set => fields.ConfirmationMailTakenOrNot[this] = value;
        }

        [DisplayName("Agreement Signing Person Name"), Size(150)]
        public String AgreementSigningPersonName
        {
            get => fields.AgreementSigningPersonName[this];
            set => fields.AgreementSigningPersonName[this] = value;
        }

        [DisplayName("Log In Loan Status"), ForeignKey("[dbo].[LogInLoanStatus]", "Id"), LeftJoin("jLogInLoanStatus"), TextualField("LogInLoanStatusName")]
        [LookupEditor(typeof(LogInLoanStatusRow))]
        public Int32? LogInLoanStatusId
        {
            get => fields.LogInLoanStatusId[this];
            set => fields.LogInLoanStatusId[this] = value;
        }

        [DisplayName("Sales Loan Status"), ForeignKey("[dbo].[SalesLoanStatus]", "Id"), LeftJoin("jSalesLoanStatus"), TextualField("SalesLoanStatusSalesLoanStatusName")]
        public Int32? SalesLoanStatusId
        {
            get => fields.SalesLoanStatusId[this];
            set => fields.SalesLoanStatusId[this] = value;
        }

        [DisplayName("Mis Disbursement Status"), Column("MISDisbursementStatusId"), ForeignKey("[dbo].[MISDisbursementStatus]", "Id"), LeftJoin("jMisDisbursementStatus"), TextualField("MisDisbursementStatusMisDisbursementStatusType")]
        [LookupEditor(typeof(MisDisbursementStatusRow))]
        public Int32? MisDisbursementStatusId
        {
            get => fields.MisDisbursementStatusId[this];
            set => fields.MisDisbursementStatusId[this] = value;
        }

        [DisplayName("Remark"), Size(500)]
        public String Remark
        {
            get => fields.Remark[this];
            set => fields.Remark[this] = value;
        }

        [DisplayName("Stage Of The Case"), ForeignKey("[dbo].[CasesStage]", "Id"), LeftJoin("jCasesStage"), TextualField("StageOfTheCaseCasesStageName")]
        [LookupEditor(typeof(CasesStageRow))]
        public Int32? StageOfTheCaseId
        {
            get => fields.StageOfTheCaseId[this];
            set => fields.StageOfTheCaseId[this] = value;
        }

        [DisplayName("Sub Insurance Pf"), Column("SubInsurancePF"), Size(200)]
        public String SubInsurancePf
        {
            get => fields.SubInsurancePf[this];
            set => fields.SubInsurancePf[this] = value;
        }

        [DisplayName("Owner"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jOwner"), TextualField("OwnerUsername"), ReadOnly(true)]
        public Int32? OwnerId
        {
            get => fields.OwnerId[this];
            set => fields.OwnerId[this] = value;
        }

        [DisplayName("Assigned"), ForeignKey("[dbo].[Users]", "UserId"), LeftJoin("jAssigned"), TextualField("AssignedUsername"),NotNull]
        public Int32? AssignedId
        {
            get => fields.AssignedId[this];
            set => fields.AssignedId[this] = value;
        }

        [DisplayName("Additional Information"), Size(200)]
        public String AdditionalInformation
        {
            get => fields.AdditionalInformation[this];
            set => fields.AdditionalInformation[this] = value;
        }

        [DisplayName("Product Product Type Name"), Expression("jTypesofProducts.[ProductTypeName]")]
        public String ProductProductTypeName
        {
            get => fields.ProductProductTypeName[this];
            set => fields.ProductProductTypeName[this] = value;
        }

        [DisplayName("Business Detail Business Detail Type"), Expression("jBusinessDetail.[BusinessDetailType]")]
        public String BusinessDetailBusinessDetailType
        {
            get => fields.BusinessDetailBusinessDetailType[this];
            set => fields.BusinessDetailBusinessDetailType[this] = value;
        }

        [DisplayName("Company Type Company Type Name"), Expression("jTypesOfCompanies.[CompanyTypeName]")]
        public String CompanyTypeCompanyTypeName
        {
            get => fields.CompanyTypeCompanyTypeName[this];
            set => fields.CompanyTypeCompanyTypeName[this] = value;
        }

        [DisplayName("Account Type Account Type Name"), Expression("jTypesOfAccounts.[AccountTypeName]")]
        public String AccountTypeAccountTypeName
        {
            get => fields.AccountTypeAccountTypeName[this];
            set => fields.AccountTypeAccountTypeName[this] = value;
        }

        [DisplayName("Month Months Name"), Expression("jMonthsInYear.[MonthsName]")]
        public String MonthMonthsName
        {
            get => fields.MonthMonthsName[this];
            set => fields.MonthMonthsName[this] = value;
        }

        [DisplayName("Bank Name Bank Names"), Expression("jBankName.[BankNames]")]
        public String BankNameBankNames
        {
            get => fields.BankNameBankNames[this];
            set => fields.BankNameBankNames[this] = value;
        }

        [DisplayName("Prime Emerging Prime Emerging Name"), Expression("jPrimeEmerging.[PrimeEmergingName]")]
        public String PrimeEmergingPrimeEmergingName
        {
            get => fields.PrimeEmergingPrimeEmergingName[this];
            set => fields.PrimeEmergingPrimeEmergingName[this] = value;
        }

        [DisplayName("Mis Direct Indirect Mis Direct Indirect Type"), Expression("jMisDirectIndirect.[MISDirectIndirectType]")]
        public String MisDirectIndirectMisDirectIndirectType
        {
            get => fields.MisDirectIndirectMisDirectIndirectType[this];
            set => fields.MisDirectIndirectMisDirectIndirectType[this] = value;
        }

        [DisplayName("Inhouse Bank In House Bank Type"), Expression("jInhouseBank.[InHouseBankType]")]
        public String InhouseBankInHouseBankType
        {
            get => fields.InhouseBankInHouseBankType[this];
            set => fields.InhouseBankInHouseBankType[this] = value;
        }

        [DisplayName("Log In Loan Status Log In Loan Status Name"), Expression("jLogInLoanStatus.[LogInLoanStatusName]")]
        public String LogInLoanStatusLogInLoanStatusName
        {
            get => fields.LogInLoanStatusLogInLoanStatusName[this];
            set => fields.LogInLoanStatusLogInLoanStatusName[this] = value;
        }

        [DisplayName("Sales Loan Status Sales Loan Status Name"), Expression("jSalesLoanStatus.[SalesLoanStatusName]")]
        public String SalesLoanStatusSalesLoanStatusName
        {
            get => fields.SalesLoanStatusSalesLoanStatusName[this];
            set => fields.SalesLoanStatusSalesLoanStatusName[this] = value;
        }

        [DisplayName("Mis Disbursement Status Mis Disbursement Status Type"), Expression("jMisDisbursementStatus.[MISDisbursementStatusType]")]
        public String MisDisbursementStatusMisDisbursementStatusType
        {
            get => fields.MisDisbursementStatusMisDisbursementStatusType[this];
            set => fields.MisDisbursementStatusMisDisbursementStatusType[this] = value;
        }

        [DisplayName("Stage Of The Case Cases Stage Name"), Expression("jCasesStage.[CasesStageName]")]
        public String StageOfTheCaseCasesStageName
        {
            get => fields.StageOfTheCaseCasesStageName[this];
            set => fields.StageOfTheCaseCasesStageName[this] = value;
        }

        [DisplayName("Owner Username"), Expression("jOwner.[Username]")]
        public String OwnerUsername
        {
            get => fields.OwnerUsername[this];
            set => fields.OwnerUsername[this] = value;
        }

        [DisplayName("Owner Display Name"), Expression("jOwner.[DisplayName]")]
        public String OwnerDisplayName
        {
            get => fields.OwnerDisplayName[this];
            set => fields.OwnerDisplayName[this] = value;
        }

        [DisplayName("Owner Email"), Expression("jOwner.[Email]")]
        public String OwnerEmail
        {
            get => fields.OwnerEmail[this];
            set => fields.OwnerEmail[this] = value;
        }

        [DisplayName("Owner Upper Level"), Expression("jOwner.[UpperLevel]")]
        public Int32? OwnerUpperLevel
        {
            get => fields.OwnerUpperLevel[this];
            set => fields.OwnerUpperLevel[this] = value;
        }

        [DisplayName("Owner Upper Level2"), Expression("jOwner.[UpperLevel2]")]
        public Int32? OwnerUpperLevel2
        {
            get => fields.OwnerUpperLevel2[this];
            set => fields.OwnerUpperLevel2[this] = value;
        }

        [DisplayName("Owner Upper Level3"), Expression("jOwner.[UpperLevel3]")]
        public Int32? OwnerUpperLevel3
        {
            get => fields.OwnerUpperLevel3[this];
            set => fields.OwnerUpperLevel3[this] = value;
        }

        [DisplayName("Owner Upper Level4"), Expression("jOwner.[UpperLevel4]")]
        public Int32? OwnerUpperLevel4
        {
            get => fields.OwnerUpperLevel4[this];
            set => fields.OwnerUpperLevel4[this] = value;
        }

        [DisplayName("Owner Upper Level5"), Expression("jOwner.[UpperLevel5]")]
        public Int32? OwnerUpperLevel5
        {
            get => fields.OwnerUpperLevel5[this];
            set => fields.OwnerUpperLevel5[this] = value;
        }

        [DisplayName("Owner Host"), Expression("jOwner.[Host]")]
        public String OwnerHost
        {
            get => fields.OwnerHost[this];
            set => fields.OwnerHost[this] = value;
        }

        [DisplayName("Owner Port"), Expression("jOwner.[Port]")]
        public Int32? OwnerPort
        {
            get => fields.OwnerPort[this];
            set => fields.OwnerPort[this] = value;
        }

        [DisplayName("Owner Ssl"), Expression("jOwner.[SSL]")]
        public Boolean? OwnerSsl
        {
            get => fields.OwnerSsl[this];
            set => fields.OwnerSsl[this] = value;
        }

        [DisplayName("Owner Email Id"), Expression("jOwner.[EmailId]")]
        public String OwnerEmailId
        {
            get => fields.OwnerEmailId[this];
            set => fields.OwnerEmailId[this] = value;
        }

        [DisplayName("Owner Email Password"), Expression("jOwner.[EmailPassword]")]
        public String OwnerEmailPassword
        {
            get => fields.OwnerEmailPassword[this];
            set => fields.OwnerEmailPassword[this] = value;
        }

        [DisplayName("Owner Phone"), Expression("jOwner.[Phone]")]
        public String OwnerPhone
        {
            get => fields.OwnerPhone[this];
            set => fields.OwnerPhone[this] = value;
        }

        [DisplayName("Owner Mcsmtp Server"), Expression("jOwner.[MCSMTPServer]")]
        public String OwnerMcsmtpServer
        {
            get => fields.OwnerMcsmtpServer[this];
            set => fields.OwnerMcsmtpServer[this] = value;
        }

        [DisplayName("Owner Mcsmtp Port"), Expression("jOwner.[MCSMTPPort]")]
        public Int32? OwnerMcsmtpPort
        {
            get => fields.OwnerMcsmtpPort[this];
            set => fields.OwnerMcsmtpPort[this] = value;
        }

        [DisplayName("Owner Mcimap Server"), Expression("jOwner.[MCIMAPServer]")]
        public String OwnerMcimapServer
        {
            get => fields.OwnerMcimapServer[this];
            set => fields.OwnerMcimapServer[this] = value;
        }

        [DisplayName("Owner Mcimap Port"), Expression("jOwner.[MCIMAPPort]")]
        public Int32? OwnerMcimapPort
        {
            get => fields.OwnerMcimapPort[this];
            set => fields.OwnerMcimapPort[this] = value;
        }

        [DisplayName("Owner Mc Username"), Expression("jOwner.[MCUsername]")]
        public String OwnerMcUsername
        {
            get => fields.OwnerMcUsername[this];
            set => fields.OwnerMcUsername[this] = value;
        }

        [DisplayName("Owner Mc Password"), Expression("jOwner.[MCPassword]")]
        public String OwnerMcPassword
        {
            get => fields.OwnerMcPassword[this];
            set => fields.OwnerMcPassword[this] = value;
        }

        [DisplayName("Owner Start Time"), Expression("jOwner.[StartTime]")]
        public String OwnerStartTime
        {
            get => fields.OwnerStartTime[this];
            set => fields.OwnerStartTime[this] = value;
        }

        [DisplayName("Owner End Time"), Expression("jOwner.[EndTime]")]
        public String OwnerEndTime
        {
            get => fields.OwnerEndTime[this];
            set => fields.OwnerEndTime[this] = value;
        }

        [DisplayName("Owner Uid"), Expression("jOwner.[UID]")]
        public String OwnerUid
        {
            get => fields.OwnerUid[this];
            set => fields.OwnerUid[this] = value;
        }

        [DisplayName("Owner Non Operational"), Expression("jOwner.[NonOperational]")]
        public Boolean? OwnerNonOperational
        {
            get => fields.OwnerNonOperational[this];
            set => fields.OwnerNonOperational[this] = value;
        }

        [DisplayName("Owner Branch Id"), Expression("jOwner.[BranchId]")]
        public Int32? OwnerBranchId
        {
            get => fields.OwnerBranchId[this];
            set => fields.OwnerBranchId[this] = value;
        }

        [DisplayName("Owner Company Id"), Expression("jOwner.[CompanyId]")]
        public Int32? OwnerCompanyId
        {
            get => fields.OwnerCompanyId[this];
            set => fields.OwnerCompanyId[this] = value;
        }

        [DisplayName("Owner Enquiry"), Expression("jOwner.[Enquiry]")]
        public Boolean? OwnerEnquiry
        {
            get => fields.OwnerEnquiry[this];
            set => fields.OwnerEnquiry[this] = value;
        }

        [DisplayName("Owner Quotation"), Expression("jOwner.[Quotation]")]
        public Boolean? OwnerQuotation
        {
            get => fields.OwnerQuotation[this];
            set => fields.OwnerQuotation[this] = value;
        }

        [DisplayName("Owner Tasks"), Expression("jOwner.[Tasks]")]
        public Boolean? OwnerTasks
        {
            get => fields.OwnerTasks[this];
            set => fields.OwnerTasks[this] = value;
        }

        [DisplayName("Owner Contacts"), Expression("jOwner.[Contacts]")]
        public Boolean? OwnerContacts
        {
            get => fields.OwnerContacts[this];
            set => fields.OwnerContacts[this] = value;
        }

        [DisplayName("Owner Purchase"), Expression("jOwner.[Purchase]")]
        public Boolean? OwnerPurchase
        {
            get => fields.OwnerPurchase[this];
            set => fields.OwnerPurchase[this] = value;
        }

        [DisplayName("Owner Sales"), Expression("jOwner.[Sales]")]
        public Boolean? OwnerSales
        {
            get => fields.OwnerSales[this];
            set => fields.OwnerSales[this] = value;
        }

        [DisplayName("Owner Cms"), Expression("jOwner.[CMS]")]
        public Boolean? OwnerCms
        {
            get => fields.OwnerCms[this];
            set => fields.OwnerCms[this] = value;
        }

        [DisplayName("Owner Location"), Expression("jOwner.[Location]")]
        public String OwnerLocation
        {
            get => fields.OwnerLocation[this];
            set => fields.OwnerLocation[this] = value;
        }

        [DisplayName("Owner Coordinates"), Expression("jOwner.[Coordinates]")]
        public String OwnerCoordinates
        {
            get => fields.OwnerCoordinates[this];
            set => fields.OwnerCoordinates[this] = value;
        }

        [DisplayName("Owner Teams Id"), Expression("jOwner.[TeamsId]")]
        public Int32? OwnerTeamsId
        {
            get => fields.OwnerTeamsId[this];
            set => fields.OwnerTeamsId[this] = value;
        }

        [DisplayName("Owner Tenant Id"), Expression("jOwner.[TenantId]")]
        public Int32? OwnerTenantId
        {
            get => fields.OwnerTenantId[this];
            set => fields.OwnerTenantId[this] = value;
        }

        [DisplayName("Owner Url"), Expression("jOwner.[Url]")]
        public String OwnerUrl
        {
            get => fields.OwnerUrl[this];
            set => fields.OwnerUrl[this] = value;
        }

        [DisplayName("Owner Plan"), Expression("jOwner.[Plan]")]
        public String OwnerPlan
        {
            get => fields.OwnerPlan[this];
            set => fields.OwnerPlan[this] = value;
        }

        [DisplayName("Assigned Username"), Expression("jAssigned.[Username]")]
        public String AssignedUsername
        {
            get => fields.AssignedUsername[this];
            set => fields.AssignedUsername[this] = value;
        }

        [DisplayName("Assigned Display Name"), Expression("jAssigned.[DisplayName]")]
        public String AssignedDisplayName
        {
            get => fields.AssignedDisplayName[this];
            set => fields.AssignedDisplayName[this] = value;
        }

        [DisplayName("Assigned Email"), Expression("jAssigned.[Email]")]
        public String AssignedEmail
        {
            get => fields.AssignedEmail[this];
            set => fields.AssignedEmail[this] = value;
        }

        [DisplayName("Assigned Upper Level"), Expression("jAssigned.[UpperLevel]")]
        public Int32? AssignedUpperLevel
        {
            get => fields.AssignedUpperLevel[this];
            set => fields.AssignedUpperLevel[this] = value;
        }

        [DisplayName("Assigned Upper Level2"), Expression("jAssigned.[UpperLevel2]")]
        public Int32? AssignedUpperLevel2
        {
            get => fields.AssignedUpperLevel2[this];
            set => fields.AssignedUpperLevel2[this] = value;
        }

        [DisplayName("Assigned Upper Level3"), Expression("jAssigned.[UpperLevel3]")]
        public Int32? AssignedUpperLevel3
        {
            get => fields.AssignedUpperLevel3[this];
            set => fields.AssignedUpperLevel3[this] = value;
        }

        [DisplayName("Assigned Upper Level4"), Expression("jAssigned.[UpperLevel4]")]
        public Int32? AssignedUpperLevel4
        {
            get => fields.AssignedUpperLevel4[this];
            set => fields.AssignedUpperLevel4[this] = value;
        }

        [DisplayName("Assigned Upper Level5"), Expression("jAssigned.[UpperLevel5]")]
        public Int32? AssignedUpperLevel5
        {
            get => fields.AssignedUpperLevel5[this];
            set => fields.AssignedUpperLevel5[this] = value;
        }

        [DisplayName("Assigned Host"), Expression("jAssigned.[Host]")]
        public String AssignedHost
        {
            get => fields.AssignedHost[this];
            set => fields.AssignedHost[this] = value;
        }

        [DisplayName("Assigned Port"), Expression("jAssigned.[Port]")]
        public Int32? AssignedPort
        {
            get => fields.AssignedPort[this];
            set => fields.AssignedPort[this] = value;
        }

        [DisplayName("Assigned Ssl"), Expression("jAssigned.[SSL]")]
        public Boolean? AssignedSsl
        {
            get => fields.AssignedSsl[this];
            set => fields.AssignedSsl[this] = value;
        }

        [DisplayName("Assigned Email Id"), Expression("jAssigned.[EmailId]")]
        public String AssignedEmailId
        {
            get => fields.AssignedEmailId[this];
            set => fields.AssignedEmailId[this] = value;
        }

        [DisplayName("Assigned Email Password"), Expression("jAssigned.[EmailPassword]")]
        public String AssignedEmailPassword
        {
            get => fields.AssignedEmailPassword[this];
            set => fields.AssignedEmailPassword[this] = value;
        }

        [DisplayName("Assigned Phone"), Expression("jAssigned.[Phone]")]
        public String AssignedPhone
        {
            get => fields.AssignedPhone[this];
            set => fields.AssignedPhone[this] = value;
        }

        [DisplayName("Assigned Mcsmtp Server"), Expression("jAssigned.[MCSMTPServer]")]
        public String AssignedMcsmtpServer
        {
            get => fields.AssignedMcsmtpServer[this];
            set => fields.AssignedMcsmtpServer[this] = value;
        }

        [DisplayName("Assigned Mcsmtp Port"), Expression("jAssigned.[MCSMTPPort]")]
        public Int32? AssignedMcsmtpPort
        {
            get => fields.AssignedMcsmtpPort[this];
            set => fields.AssignedMcsmtpPort[this] = value;
        }

        [DisplayName("Assigned Mcimap Server"), Expression("jAssigned.[MCIMAPServer]")]
        public String AssignedMcimapServer
        {
            get => fields.AssignedMcimapServer[this];
            set => fields.AssignedMcimapServer[this] = value;
        }

        [DisplayName("Assigned Mcimap Port"), Expression("jAssigned.[MCIMAPPort]")]
        public Int32? AssignedMcimapPort
        {
            get => fields.AssignedMcimapPort[this];
            set => fields.AssignedMcimapPort[this] = value;
        }

        [DisplayName("Assigned Mc Username"), Expression("jAssigned.[MCUsername]")]
        public String AssignedMcUsername
        {
            get => fields.AssignedMcUsername[this];
            set => fields.AssignedMcUsername[this] = value;
        }

        [DisplayName("Assigned Mc Password"), Expression("jAssigned.[MCPassword]")]
        public String AssignedMcPassword
        {
            get => fields.AssignedMcPassword[this];
            set => fields.AssignedMcPassword[this] = value;
        }

        [DisplayName("Assigned Start Time"), Expression("jAssigned.[StartTime]")]
        public String AssignedStartTime
        {
            get => fields.AssignedStartTime[this];
            set => fields.AssignedStartTime[this] = value;
        }

        [DisplayName("Assigned End Time"), Expression("jAssigned.[EndTime]")]
        public String AssignedEndTime
        {
            get => fields.AssignedEndTime[this];
            set => fields.AssignedEndTime[this] = value;
        }

        [DisplayName("Assigned Uid"), Expression("jAssigned.[UID]")]
        public String AssignedUid
        {
            get => fields.AssignedUid[this];
            set => fields.AssignedUid[this] = value;
        }

        [DisplayName("Assigned Non Operational"), Expression("jAssigned.[NonOperational]")]
        public Boolean? AssignedNonOperational
        {
            get => fields.AssignedNonOperational[this];
            set => fields.AssignedNonOperational[this] = value;
        }

        [DisplayName("Assigned Branch Id"), Expression("jAssigned.[BranchId]")]
        public Int32? AssignedBranchId
        {
            get => fields.AssignedBranchId[this];
            set => fields.AssignedBranchId[this] = value;
        }

        [DisplayName("Assigned Company Id"), Expression("jAssigned.[CompanyId]")]
        public Int32? AssignedCompanyId
        {
            get => fields.AssignedCompanyId[this];
            set => fields.AssignedCompanyId[this] = value;
        }

        [DisplayName("Assigned Enquiry"), Expression("jAssigned.[Enquiry]")]
        public Boolean? AssignedEnquiry
        {
            get => fields.AssignedEnquiry[this];
            set => fields.AssignedEnquiry[this] = value;
        }

        [DisplayName("Assigned Quotation"), Expression("jAssigned.[Quotation]")]
        public Boolean? AssignedQuotation
        {
            get => fields.AssignedQuotation[this];
            set => fields.AssignedQuotation[this] = value;
        }

        [DisplayName("Assigned Tasks"), Expression("jAssigned.[Tasks]")]
        public Boolean? AssignedTasks
        {
            get => fields.AssignedTasks[this];
            set => fields.AssignedTasks[this] = value;
        }

        [DisplayName("Assigned Contacts"), Expression("jAssigned.[Contacts]")]
        public Boolean? AssignedContacts
        {
            get => fields.AssignedContacts[this];
            set => fields.AssignedContacts[this] = value;
        }

        [DisplayName("Assigned Purchase"), Expression("jAssigned.[Purchase]")]
        public Boolean? AssignedPurchase
        {
            get => fields.AssignedPurchase[this];
            set => fields.AssignedPurchase[this] = value;
        }

        [DisplayName("Assigned Sales"), Expression("jAssigned.[Sales]")]
        public Boolean? AssignedSales
        {
            get => fields.AssignedSales[this];
            set => fields.AssignedSales[this] = value;
        }

        [DisplayName("Assigned Cms"), Expression("jAssigned.[CMS]")]
        public Boolean? AssignedCms
        {
            get => fields.AssignedCms[this];
            set => fields.AssignedCms[this] = value;
        }

        [DisplayName("Assigned Location"), Expression("jAssigned.[Location]")]
        public String AssignedLocation
        {
            get => fields.AssignedLocation[this];
            set => fields.AssignedLocation[this] = value;
        }

        [DisplayName("Assigned Coordinates"), Expression("jAssigned.[Coordinates]")]
        public String AssignedCoordinates
        {
            get => fields.AssignedCoordinates[this];
            set => fields.AssignedCoordinates[this] = value;
        }

        [DisplayName("Assigned Teams Id"), Expression("jAssigned.[TeamsId]")]
        public Int32? AssignedTeamsId
        {
            get => fields.AssignedTeamsId[this];
            set => fields.AssignedTeamsId[this] = value;
        }

        [DisplayName("Assigned Tenant Id"), Expression("jAssigned.[TenantId]")]
        public Int32? AssignedTenantId
        {
            get => fields.AssignedTenantId[this];
            set => fields.AssignedTenantId[this] = value;
        }

        [DisplayName("Assigned Url"), Expression("jAssigned.[Url]")]
        public String AssignedUrl
        {
            get => fields.AssignedUrl[this];
            set => fields.AssignedUrl[this] = value;
        }

        [DisplayName("Assigned Plan"), Expression("jAssigned.[Plan]")]
        public String AssignedPlan
        {
            get => fields.AssignedPlan[this];
            set => fields.AssignedPlan[this] = value;
        }

        public InsideSalesRow()
            : base()
        {
            this.MonthId = DateTime.Now.Month;
            FileReceivedDateTime = DateTime.Now;
        }

        public InsideSalesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SrNo;
            public StringField SourceName;
            public StringField CustomerName;
            public StringField FirmName;
            public StringField BankSourceOrCompanyName;
            public StringField FileHandledBy;
            public StringField ContactPersonInTeam;
            public StringField SalesManager;
            public StringField Location;
            public Int32Field ProductId;
            public StringField Requirement;
            public StringField NatureOfBusinessProfile;
            public StringField ProfileOfTheLead;
            public StringField BusinessVintage;
            public Int32Field BusinessDetailId;
            public Int32Field CompanyTypeId;
            public Int32Field AccountTypeId;
            public DateTimeField FileReceivedDateTime;
            public DateTimeField QueriesGivenTime;
            public DateTimeField FileCompletionDateTime;
            public DateTimeField SystemLoginDate;
            public DateTimeField UnderwritingDate;
            public DateTimeField DisbursementDate;
            public StringField Year;
            public Int32Field MonthId;
            public Int32Field BankNameId;
            public StringField LoanAccountNumber;
            public Int32Field PrimeEmergingId;
            public Int32Field MisDirectIndirectId;
            public Int32Field InhouseBankId;
            public DecimalField LoanAmount;
            public DecimalField Amount;
            public DecimalField NetAmt;
            public DecimalField AdvanceEmi;
            public DecimalField ToPreviousYear;
            public DecimalField ToLatestYear;
            public StringField ContactNumber;
            public StringField CompanyMailId;
            public StringField EmployeeName;
            public StringField ConfirmationMailTakenOrNot;
            public StringField AgreementSigningPersonName;
            public Int32Field LogInLoanStatusId;
            public Int32Field SalesLoanStatusId;
            public Int32Field MisDisbursementStatusId;
            public StringField Remark;
            public Int32Field StageOfTheCaseId;
            public StringField SubInsurancePf;
            public Int32Field OwnerId;
            public Int32Field AssignedId;
            public StringField AdditionalInformation;

            public StringField ProductProductTypeName;

            public StringField BusinessDetailBusinessDetailType;

            public StringField CompanyTypeCompanyTypeName;

            public StringField AccountTypeAccountTypeName;

            public StringField MonthMonthsName;

            public StringField BankNameBankNames;

            public StringField PrimeEmergingPrimeEmergingName;

            public StringField MisDirectIndirectMisDirectIndirectType;

            public StringField InhouseBankInHouseBankType;

            public StringField LogInLoanStatusLogInLoanStatusName;

            public StringField SalesLoanStatusSalesLoanStatusName;

            public StringField MisDisbursementStatusMisDisbursementStatusType;

            public StringField StageOfTheCaseCasesStageName;

            public StringField OwnerUsername;
            public StringField OwnerDisplayName;
            public StringField OwnerEmail;
            public Int32Field OwnerUpperLevel;
            public Int32Field OwnerUpperLevel2;
            public Int32Field OwnerUpperLevel3;
            public Int32Field OwnerUpperLevel4;
            public Int32Field OwnerUpperLevel5;
            public StringField OwnerHost;
            public Int32Field OwnerPort;
            public BooleanField OwnerSsl;
            public StringField OwnerEmailId;
            public StringField OwnerEmailPassword;
            public StringField OwnerPhone;
            public StringField OwnerMcsmtpServer;
            public Int32Field OwnerMcsmtpPort;
            public StringField OwnerMcimapServer;
            public Int32Field OwnerMcimapPort;
            public StringField OwnerMcUsername;
            public StringField OwnerMcPassword;
            public StringField OwnerStartTime;
            public StringField OwnerEndTime;
            public StringField OwnerUid;
            public BooleanField OwnerNonOperational;
            public Int32Field OwnerBranchId;
            public Int32Field OwnerCompanyId;
            public BooleanField OwnerEnquiry;
            public BooleanField OwnerQuotation;
            public BooleanField OwnerTasks;
            public BooleanField OwnerContacts;
            public BooleanField OwnerPurchase;
            public BooleanField OwnerSales;
            public BooleanField OwnerCms;
            public StringField OwnerLocation;
            public StringField OwnerCoordinates;
            public Int32Field OwnerTeamsId;
            public Int32Field OwnerTenantId;
            public StringField OwnerUrl;
            public StringField OwnerPlan;

            public StringField AssignedUsername;
            public StringField AssignedDisplayName;
            public StringField AssignedEmail;
            public Int32Field AssignedUpperLevel;
            public Int32Field AssignedUpperLevel2;
            public Int32Field AssignedUpperLevel3;
            public Int32Field AssignedUpperLevel4;
            public Int32Field AssignedUpperLevel5;
            public StringField AssignedHost;
            public Int32Field AssignedPort;
            public BooleanField AssignedSsl;
            public StringField AssignedEmailId;
            public StringField AssignedEmailPassword;
            public StringField AssignedPhone;
            public StringField AssignedMcsmtpServer;
            public Int32Field AssignedMcsmtpPort;
            public StringField AssignedMcimapServer;
            public Int32Field AssignedMcimapPort;
            public StringField AssignedMcUsername;
            public StringField AssignedMcPassword;
            public StringField AssignedStartTime;
            public StringField AssignedEndTime;
            public StringField AssignedUid;
            public BooleanField AssignedNonOperational;
            public Int32Field AssignedBranchId;
            public Int32Field AssignedCompanyId;
            public BooleanField AssignedEnquiry;
            public BooleanField AssignedQuotation;
            public BooleanField AssignedTasks;
            public BooleanField AssignedContacts;
            public BooleanField AssignedPurchase;
            public BooleanField AssignedSales;
            public BooleanField AssignedCms;
            public StringField AssignedLocation;
            public StringField AssignedCoordinates;
            public Int32Field AssignedTeamsId;
            public Int32Field AssignedTenantId;
            public StringField AssignedUrl;
            public StringField AssignedPlan;
        }
    }
}
