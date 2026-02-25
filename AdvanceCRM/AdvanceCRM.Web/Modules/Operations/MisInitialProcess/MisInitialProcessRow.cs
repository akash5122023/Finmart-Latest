using AdvanceCRM.Contacts;
using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Operations
{
    [ConnectionKey("Default"), Module("Operations"), TableName("[dbo].[MISInitialProcess]")]
    [DisplayName("Mis Initial Process"), InstanceName("Mis Initial Process")]
    [ReadPermission("MISInitialProcess:Read")]
    [InsertPermission("MISInitialProcess:Insert")]
    [UpdatePermission("MISInitialProcess:Update")]
    [DeletePermission("MISInitialProcess:Delete")]
    [LookupScript("Operations.MISInitialProcess", Permission = "?")]
    public sealed class MisInitialProcessRow : Row<MisInitialProcessRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Sr No"), Size(50), QuickSearch]
        public String SrNo
        {
            get => fields.SrNo[this];
            set => fields.SrNo[this] = value;
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

        [DisplayName("Products"), ForeignKey("[dbo].[TypesofProducts]", "Id"), LeftJoin("jTypesofProducts"), TextualField("ProductTypeName"), QuickFilter]
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }
        [DisplayName("Product Name"), Expression("jTypesofProducts.[ProductTypeName]")]
        public String ProductProductTypeName
        {
            get => fields.ProductProductTypeName[this];
            set => fields.ProductProductTypeName[this] = value;
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

        [DisplayName("Business Detail"), ForeignKey("[dbo].[BusinessDetails]", "Id"), LeftJoin("jBusinessDetail"), TextualField("BusinessDetailBusinessDetailType")]
        public Int32? BusinessDetailId
        {
            get => fields.BusinessDetailId[this];
            set => fields.BusinessDetailId[this] = value;
        }
        [DisplayName("Lead Stage"), ForeignKey("[dbo].[LeadStage]", "Id"), LeftJoin("jLeadStage"), TextualField("LeadStageName")]
        [LookupEditor(typeof(LeadStageRow))]
        public Int32? LeadStageId
        {
            get => fields.LeadStageId[this];
            set => fields.LeadStageId[this] = value;
        }
        [DisplayName("Source Id"), ForeignKey("[dbo].[RRSource]", "Id"), LeftJoin("jRRSource"), TextualField("SourceName")]
        [LookupEditor(typeof(RrSourceRow), InplaceAdd = true)]
        public Int32? RRSourceId
        {
            get => fields.RRSourceId[this];
            set => fields.RRSourceId[this] = value;
        }
        [DisplayName("Source Name"), Expression("jRRSource.[SourceName]")]
        public String SourceName
        {
            get => fields.SourceName[this];
            set => fields.SourceName[this] = value;
        }
        [DisplayName("LeadStage Name"), Expression("jLeadStage.[LeadStageName]")]
        public String LeadStageName
        {
            get => fields.LeadStageName[this];
            set => fields.LeadStageName[this] = value;
        }
        [DisplayName("Company Type"), ForeignKey("[dbo].[TypesOfCompanies]", "Id"), LeftJoin("jCompanyType"), TextualField("CompanyTypeCompanyTypeName")]
        public Int32? CompanyTypeId
        {
            get => fields.CompanyTypeId[this];
            set => fields.CompanyTypeId[this] = value;
        }

        [DisplayName("Account Type"), ForeignKey("[dbo].[TypesOfAccounts]", "Id"), LeftJoin("jAccountType"), TextualField("AccountTypeAccountTypeName")]
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

        [DisplayName("Month"), ForeignKey("[dbo].[MonthsInYear]", "Id"), LeftJoin("jMonth"), TextualField("MonthMonthsName")]
        public Int32? MonthId
        {
            get => fields.MonthId[this];
            set => fields.MonthId[this] = value;
        }

        [DisplayName("Bank Name"), ForeignKey("[dbo].[BankName]", "Id"), LeftJoin("jBankName"), TextualField("BankNames"), QuickFilter]
        [LookupEditor(typeof(BankNameRow))]
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
        public Int32? PrimeEmergingId
        {
            get => fields.PrimeEmergingId[this];
            set => fields.PrimeEmergingId[this] = value;
        }

        [DisplayName("Mis Direct Indirect"), Column("MISDirectIndirectId"), ForeignKey("[dbo].[MISDirectIndirect]", "Id"), LeftJoin("jMisDirectIndirect"), TextualField("MisDirectIndirectMisDirectIndirectType")]
        public Int32? MisDirectIndirectId
        {
            get => fields.MisDirectIndirectId[this];
            set => fields.MisDirectIndirectId[this] = value;
        }

        [DisplayName("Inhouse Bank"), ForeignKey("[dbo].[InHouseBank]", "Id"), LeftJoin("jInhouseBank"), TextualField("InhouseBankInHouseBankType")]
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

        [DisplayName("Log In Loan Status"), ForeignKey("[dbo].[LogInLoanStatus]", "Id"), LeftJoin("jLogInLoanStatus"), TextualField("LogInLoanStatusLogInLoanStatusName")]
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

        [DisplayName("Stage Of The Case"), Size(150)]
        public String StageOfTheCase
        {
            get => fields.StageOfTheCase[this];
            set => fields.StageOfTheCase[this] = value;
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

        [DisplayName("Customer Type"), NotMapped]
        public Masters.ContactTypeMaster? CustomerType
        {
            get => (Masters.ContactTypeMaster?)Fields.CustomerType[this];
            set => Fields.CustomerType[this] = (Int32?)value;
        }

        [DisplayName("Contacts"), NotNull, ForeignKey("[dbo].[Contacts]", "Id"), LeftJoin("jContacts"), TextualField("ContactsName")]
        [LookupEditor(typeof(ContactsRow), InplaceAdd = true, CascadeFrom = "CustomerType", CascadeField = "CustomerType")]
        public Int32? ContactsId
        {
            get { return Fields.ContactsId[this]; }
            set { Fields.ContactsId[this] = value; }
        }
        [DisplayName("Contact Person"), ForeignKey("[dbo].[SubContacts]", "Id"), LeftJoin("jContactPerson"), TextualField("ContactPersonName")]
        [LookupEditor(typeof(SubContactsRow), CascadeFrom = "ContactsId", CascadeValue = "ContactsId")]
        public Int32? ContactPersonId
        {
            get { return Fields.ContactPersonId[this]; }
            set { Fields.ContactPersonId[this] = value; }
        }
        [DisplayName("Contacts Contact Type"), Expression("jContacts.[ContactType]")]
        public Int32? ContactsContactType
        {
            get { return Fields.ContactsContactType[this]; }
            set { Fields.ContactsContactType[this] = value; }
        }
        [DisplayName("Contact"), Expression("jContacts.[Name]"), QuickSearch, NameProperty]
        public String ContactsName
        {
            get { return Fields.ContactsName[this]; }
            set { Fields.ContactsName[this] = value; }
        }

        [DisplayName("Phone"), Expression("jContacts.[Phone]"), QuickSearch, LookupInclude]
        public String ContactsPhone
        {
            get { return Fields.ContactsPhone[this]; }
            set { Fields.ContactsPhone[this] = value; }
        }

        [DisplayName("Contacts Email"), Expression("jContacts.[Email]"), LookupInclude]
        public String ContactsEmail
        {
            get { return Fields.ContactsEmail[this]; }
            set { Fields.ContactsEmail[this] = value; }
        }
        [DisplayName("Contact Person"), Expression("jContactPerson.[Name]"), QuickSearch]
        public String ContactPersonName
        {
            get { return Fields.ContactPersonName[this]; }
            set { Fields.ContactPersonName[this] = value; }
        }
        [DisplayName("Address"), Expression("jContacts.[Address]"), TextAreaEditor(Rows = 4)]
        public String ContactsAddress
        {
            get { return Fields.ContactsAddress[this]; }
            set { Fields.ContactsAddress[this] = value; }
        }

        [DisplayName("Contacts City Id"), Expression("jContacts.[CityId]")]
        public Int32? ContactsCityId
        {
            get { return Fields.ContactsCityId[this]; }
            set { Fields.ContactsCityId[this] = value; }
        }

        [DisplayName("Contacts State Id"), Expression("jContacts.[StateId]")]
        public Int32? ContactsStateId
        {
            get { return Fields.ContactsStateId[this]; }
            set { Fields.ContactsStateId[this] = value; }
        }

        [DisplayName("Contacts Pin"), Expression("jContacts.[Pin]")]
        public String ContactsPin
        {
            get { return Fields.ContactsPin[this]; }
            set { Fields.ContactsPin[this] = value; }
        }

        [DisplayName("Contacts Country"), Expression("jContacts.[Country]")]
        public Int32? ContactsCountry
        {
            get { return Fields.ContactsCountry[this]; }
            set { Fields.ContactsCountry[this] = value; }
        }

        [DisplayName("Contacts Website"), Expression("jContacts.[Website]")]
        public String ContactsWebsite
        {
            get { return Fields.ContactsWebsite[this]; }
            set { Fields.ContactsWebsite[this] = value; }
        }

        [DisplayName("Contacts Additional Info"), Expression("jContacts.[AdditionalInfo]")]
        public String ContactsAdditionalInfo
        {
            get { return Fields.ContactsAdditionalInfo[this]; }
            set { Fields.ContactsAdditionalInfo[this] = value; }
        }

        [DisplayName("Contacts Residential Phone"), Expression("jContacts.[ResidentialPhone]")]
        public String ContactsResidentialPhone
        {
            get { return Fields.ContactsResidentialPhone[this]; }
            set { Fields.ContactsResidentialPhone[this] = value; }
        }

        [DisplayName("Contacts Office Phone"), Expression("jContacts.[OfficePhone]")]
        public String ContactsOfficePhone
        {
            get { return Fields.ContactsOfficePhone[this]; }
            set { Fields.ContactsOfficePhone[this] = value; }
        }

        [DisplayName("Contacts Gender"), Expression("jContacts.[Gender]")]
        public Int32? ContactsGender
        {
            get { return Fields.ContactsGender[this]; }
            set { Fields.ContactsGender[this] = value; }
        }

        [DisplayName("Contacts Religion"), Expression("jContacts.[Religion]")]
        public Int32? ContactsReligion
        {
            get { return Fields.ContactsReligion[this]; }
            set { Fields.ContactsReligion[this] = value; }
        }

        [DisplayName("Contacts Area Id"), Expression("jContacts.[AreaId]")]
        public Int32? ContactsAreaId
        {
            get { return Fields.ContactsAreaId[this]; }
            set { Fields.ContactsAreaId[this] = value; }
        }

        [DisplayName("Contacts Marital Status"), Expression("jContacts.[MaritalStatus]")]
        public Int32? ContactsMaritalStatus
        {
            get { return Fields.ContactsMaritalStatus[this]; }
            set { Fields.ContactsMaritalStatus[this] = value; }
        }

        [DisplayName("Contacts Marriage Anniversary"), Expression("jContacts.[MarriageAnniversary]")]
        public DateTime? ContactsMarriageAnniversary
        {
            get { return Fields.ContactsMarriageAnniversary[this]; }
            set { Fields.ContactsMarriageAnniversary[this] = value; }
        }

        [DisplayName("Contacts Birthdate"), Expression("jContacts.[Birthdate]")]
        public DateTime? ContactsBirthdate
        {
            get { return Fields.ContactsBirthdate[this]; }
            set { Fields.ContactsBirthdate[this] = value; }
        }

        [DisplayName("Contacts Date Of Incorporation"), Expression("jContacts.[DateOfIncorporation]")]
        public DateTime? ContactsDateOfIncorporation
        {
            get { return Fields.ContactsDateOfIncorporation[this]; }
            set { Fields.ContactsDateOfIncorporation[this] = value; }
        }

        [DisplayName("Contacts Category Id"), Expression("jContacts.[CategoryId]")]
        public Int32? ContactsCategoryId
        {
            get { return Fields.ContactsCategoryId[this]; }
            set { Fields.ContactsCategoryId[this] = value; }
        }

        [DisplayName("Contacts Grade Id"), Expression("jContacts.[GradeId]")]
        public Int32? ContactsGradeId
        {
            get { return Fields.ContactsGradeId[this]; }
            set { Fields.ContactsGradeId[this] = value; }
        }

        [DisplayName("Contacts Type"), Expression("jContacts.[Type]")]
        public Int32? ContactsType
        {
            get { return Fields.ContactsType[this]; }
            set { Fields.ContactsType[this] = value; }
        }

        [DisplayName("Contacts Owner Id"), Expression("jContacts.[OwnerId]")]
        public Int32? ContactsOwnerId
        {
            get { return Fields.ContactsOwnerId[this]; }
            set { Fields.ContactsOwnerId[this] = value; }
        }

        [DisplayName("Contacts Assigned Id"), Expression("jContacts.[AssignedId]")]
        public Int32? ContactsAssignedId
        {
            get { return Fields.ContactsAssignedId[this]; }
            set { Fields.ContactsAssignedId[this] = value; }
        }

        [DisplayName("Contacts Channel Category"), Expression("jContacts.[ChannelCategory]")]
        public Int32? ContactsChannelCategory
        {
            get { return Fields.ContactsChannelCategory[this]; }
            set { Fields.ContactsChannelCategory[this] = value; }
        }

        [DisplayName("Contacts National Distributor"), Expression("jContacts.[NationalDistributor]")]
        public Int32? ContactsNationalDistributor
        {
            get { return Fields.ContactsNationalDistributor[this]; }
            set { Fields.ContactsNationalDistributor[this] = value; }
        }

        [DisplayName("Contacts Stockist"), Expression("jContacts.[Stockist]")]
        public Int32? ContactsStockist
        {
            get { return Fields.ContactsStockist[this]; }
            set { Fields.ContactsStockist[this] = value; }
        }

        [DisplayName("Contacts Distributor"), Expression("jContacts.[Distributor]")]
        public Int32? ContactsDistributor
        {
            get { return Fields.ContactsDistributor[this]; }
            set { Fields.ContactsDistributor[this] = value; }
        }

        [DisplayName("Contacts Dealer"), Expression("jContacts.[Dealer]")]
        public Int32? ContactsDealer
        {
            get { return Fields.ContactsDealer[this]; }
            set { Fields.ContactsDealer[this] = value; }
        }

        [DisplayName("Contacts Wholesaler"), Expression("jContacts.[Wholesaler]")]
        public Int32? ContactsWholesaler
        {
            get { return Fields.ContactsWholesaler[this]; }
            set { Fields.ContactsWholesaler[this] = value; }
        }

        [DisplayName("Contacts Reseller"), Expression("jContacts.[Reseller]")]
        public Int32? ContactsReseller
        {
            get { return Fields.ContactsReseller[this]; }
            set { Fields.ContactsReseller[this] = value; }
        }

        [DisplayName("Contacts GSTIN"), Expression("jContacts.[GSTIN]")]
        public String ContactsGstin
        {
            get { return Fields.ContactsGstin[this]; }
            set { Fields.ContactsGstin[this] = value; }
        }

        [DisplayName("Contacts Pan No"), Expression("jContacts.[PANNo]")]
        public String ContactsPanNo
        {
            get { return Fields.ContactsPanNo[this]; }
            set { Fields.ContactsPanNo[this] = value; }
        }

        [DisplayName("Contacts Cc Emails"), Expression("jContacts.[CCEmails]")]
        public String ContactsCcEmails
        {
            get { return Fields.ContactsCcEmails[this]; }
            set { Fields.ContactsCcEmails[this] = value; }
        }

        [DisplayName("Contacts Bcc Emails"), Expression("jContacts.[BCCEmails]")]
        public String ContactsBccEmails
        {
            get { return Fields.ContactsBccEmails[this]; }
            set { Fields.ContactsBccEmails[this] = value; }
        }

        [DisplayName("Contacts Attachment"), Expression("jContacts.[Attachment]")]
        public String ContactsAttachment
        {
            get { return Fields.ContactsAttachment[this]; }
            set { Fields.ContactsAttachment[this] = value; }
        }

        [DisplayName("Contacts E Com GSTIN"), Expression("jContacts.[EComGSTIN]")]
        public String ContactsEComGstin
        {
            get { return Fields.ContactsEComGstin[this]; }
            set { Fields.ContactsEComGstin[this] = value; }
        }

        [DisplayName("Contacts Creditors Opening"), Expression("jContacts.[CreditorsOpening]")]
        public Double? ContactsCreditorsOpening
        {
            get { return Fields.ContactsCreditorsOpening[this]; }
            set { Fields.ContactsCreditorsOpening[this] = value; }
        }

        [DisplayName("Contacts Debtors Opening"), Expression("jContacts.[DebtorsOpening]")]
        public Double? ContactsDebtorsOpening
        {
            get { return Fields.ContactsDebtorsOpening[this]; }
            set { Fields.ContactsDebtorsOpening[this] = value; }
        }

        [DisplayName("Contacts Bank Name"), Expression("jContacts.[BankName]")]
        public String ContactsBankName
        {
            get { return Fields.ContactsBankName[this]; }
            set { Fields.ContactsBankName[this] = value; }
        }

        [DisplayName("Contacts Account Number"), Expression("jContacts.[AccountNumber]")]
        public String ContactsAccountNumber
        {
            get { return Fields.ContactsAccountNumber[this]; }
            set { Fields.ContactsAccountNumber[this] = value; }
        }

        [DisplayName("Contacts Ifsc"), Expression("jContacts.[IFSC]")]
        public String ContactsIfsc
        {
            get { return Fields.ContactsIfsc[this]; }
            set { Fields.ContactsIfsc[this] = value; }
        }

        [DisplayName("Contacts Bank Type"), Expression("jContacts.[BankType]")]
        public String ContactsBankType
        {
            get { return Fields.ContactsBankType[this]; }
            set { Fields.ContactsBankType[this] = value; }
        }

        [DisplayName("Contacts Branch"), Expression("jContacts.[Branch]")]
        public String ContactsBranch
        {
            get { return Fields.ContactsBranch[this]; }
            set { Fields.ContactsBranch[this] = value; }
        }

        [DisplayName("Contacts Accounts Email"), Expression("jContacts.[AccountsEmail]")]
        public String ContactsAccountsEmail
        {
            get { return Fields.ContactsAccountsEmail[this]; }
            set { Fields.ContactsAccountsEmail[this] = value; }
        }

        [DisplayName("Contacts Purchase Email"), Expression("jContacts.[PurchaseEmail]")]
        public String ContactsPurchaseEmail
        {
            get { return Fields.ContactsPurchaseEmail[this]; }
            set { Fields.ContactsPurchaseEmail[this] = value; }
        }

        [DisplayName("Contacts Service Email"), Expression("jContacts.[ServiceEmail]")]
        public String ContactsServiceEmail
        {
            get { return Fields.ContactsServiceEmail[this]; }
            set { Fields.ContactsServiceEmail[this] = value; }
        }

        [DisplayName("Contacts Sales Email"), Expression("jContacts.[SalesEmail]")]
        public String ContactsSalesEmail
        {
            get { return Fields.ContactsSalesEmail[this]; }
            set { Fields.ContactsSalesEmail[this] = value; }
        }

        [DisplayName("Contacts Credit Days"), Expression("jContacts.[CreditDays]")]
        public Int32? ContactsCreditDays
        {
            get { return Fields.ContactsCreditDays[this]; }
            set { Fields.ContactsCreditDays[this] = value; }
        }

        [DisplayName("Contacts Customer Type"), Expression("jContacts.[CustomerType]")]
        public Int32? ContactsCustomerType
        {
            get { return Fields.ContactsCustomerType[this]; }
            set { Fields.ContactsCustomerType[this] = value; }
        }

        [DisplayName("Contacts Trasportation Id"), Expression("jContacts.[TrasportationId]")]
        public Int32? ContactsTrasportationId
        {
            get { return Fields.ContactsTrasportationId[this]; }
            set { Fields.ContactsTrasportationId[this] = value; }
        }

        [DisplayName("Contacts Tehsil Id"), Expression("jContacts.[TehsilId]")]
        public Int32? ContactsTehsilId
        {
            get { return Fields.ContactsTehsilId[this]; }
            set { Fields.ContactsTehsilId[this] = value; }
        }

        [DisplayName("Contacts Village Id"), Expression("jContacts.[VillageId]")]
        public Int32? ContactsVillageId
        {
            get { return Fields.ContactsVillageId[this]; }
            set { Fields.ContactsVillageId[this] = value; }
        }

        [DisplayName("Contacts Whatsapp"), Expression("jContacts.[Whatsapp]")]
        public String ContactsWhatsapp
        {
            get { return Fields.ContactsWhatsapp[this]; }
            set { Fields.ContactsWhatsapp[this] = value; }
        }

       

        [DisplayName("Business Detail Business Detail Type"), Expression("jBusinessDetail.[BusinessDetailType]")]
        public String BusinessDetailBusinessDetailType
        {
            get => fields.BusinessDetailBusinessDetailType[this];
            set => fields.BusinessDetailBusinessDetailType[this] = value;
        }

        [DisplayName("Company Type Company Type Name"), Expression("jCompanyType.[CompanyTypeName]")]
        public String CompanyTypeCompanyTypeName
        {
            get => fields.CompanyTypeCompanyTypeName[this];
            set => fields.CompanyTypeCompanyTypeName[this] = value;
        }

        [DisplayName("Account Type Account Type Name"), Expression("jAccountType.[AccountTypeName]")]
        public String AccountTypeAccountTypeName
        {
            get => fields.AccountTypeAccountTypeName[this];
            set => fields.AccountTypeAccountTypeName[this] = value;
        }

        [DisplayName("Month Months Name"), Expression("jMonth.[MonthsName]")]
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

        [DisplayName("Contacts Consent For Calling"), Expression("jContacts.[ConsentForCalling]")]
        public Boolean? ContactsConsentForCalling
        {
            get => fields.ContactsConsentForCalling[this];
            set => fields.ContactsConsentForCalling[this] = value;
        }

        [DisplayName("Contacts Additional Info2"), Expression("jContacts.[AdditionalInfo2]")]
        public String ContactsAdditionalInfo2
        {
            get => fields.ContactsAdditionalInfo2[this];
            set => fields.ContactsAdditionalInfo2[this] = value;
        }

        [DisplayName("Contacts Date Created"), Expression("jContacts.[DateCreated]")]
        public DateTime? ContactsDateCreated
        {
            get => fields.ContactsDateCreated[this];
            set => fields.ContactsDateCreated[this] = value;
        }

        [DisplayName("Contacts Passport Number"), Expression("jContacts.[PassportNumber]")]
        public String ContactsPassportNumber
        {
            get => fields.ContactsPassportNumber[this];
            set => fields.ContactsPassportNumber[this] = value;
        }

        [DisplayName("Contacts First Name"), Expression("jContacts.[FirstName]")]
        public String ContactsFirstName
        {
            get => fields.ContactsFirstName[this];
            set => fields.ContactsFirstName[this] = value;
        }

        [DisplayName("Contacts Last Name"), Expression("jContacts.[LastName]")]
        public String ContactsLastName
        {
            get => fields.ContactsLastName[this];
            set => fields.ContactsLastName[this] = value;
        }

        [DisplayName("Contacts Expiry Date"), Expression("jContacts.[ExpiryDate]")]
        public DateTime? ContactsExpiryDate
        {
            get => fields.ContactsExpiryDate[this];
            set => fields.ContactsExpiryDate[this] = value;
        }

        [DisplayName("Contacts Aadhar No"), Expression("jContacts.[AadharNo]")]
        public String ContactsAadharNo
        {
            get => fields.ContactsAadharNo[this];
            set => fields.ContactsAadharNo[this] = value;
        }

        //[DisplayName("Contact Person Name"), Expression("jContactPerson.[Name]")]
        //public String ContactPersonName
        //{
        //    get => fields.ContactPersonName[this];
        //    set => fields.ContactPersonName[this] = value;
        //}

        [DisplayName("Contact Person Phone"), Expression("jContactPerson.[Phone]")]
        public String ContactPersonPhone
        {
            get => fields.ContactPersonPhone[this];
            set => fields.ContactPersonPhone[this] = value;
        }

        [DisplayName("Contact Person Residential Phone"), Expression("jContactPerson.[ResidentialPhone]")]
        public String ContactPersonResidentialPhone
        {
            get => fields.ContactPersonResidentialPhone[this];
            set => fields.ContactPersonResidentialPhone[this] = value;
        }

        [DisplayName("Contact Person Email"), Expression("jContactPerson.[Email]")]
        public String ContactPersonEmail
        {
            get => fields.ContactPersonEmail[this];
            set => fields.ContactPersonEmail[this] = value;
        }

        [DisplayName("Contact Person Designation"), Expression("jContactPerson.[Designation]")]
        public String ContactPersonDesignation
        {
            get => fields.ContactPersonDesignation[this];
            set => fields.ContactPersonDesignation[this] = value;
        }

        [DisplayName("Contact Person Address"), Expression("jContactPerson.[Address]")]
        public String ContactPersonAddress
        {
            get => fields.ContactPersonAddress[this];
            set => fields.ContactPersonAddress[this] = value;
        }

        [DisplayName("Contact Person Gender"), Expression("jContactPerson.[Gender]")]
        public Int32? ContactPersonGender
        {
            get => fields.ContactPersonGender[this];
            set => fields.ContactPersonGender[this] = value;
        }

        [DisplayName("Contact Person Religion"), Expression("jContactPerson.[Religion]")]
        public Int32? ContactPersonReligion
        {
            get => fields.ContactPersonReligion[this];
            set => fields.ContactPersonReligion[this] = value;
        }

        [DisplayName("Contact Person Marital Status"), Expression("jContactPerson.[MaritalStatus]")]
        public Int32? ContactPersonMaritalStatus
        {
            get => fields.ContactPersonMaritalStatus[this];
            set => fields.ContactPersonMaritalStatus[this] = value;
        }

        [DisplayName("Contact Person Marriage Anniversary"), Expression("jContactPerson.[MarriageAnniversary]")]
        public DateTime? ContactPersonMarriageAnniversary
        {
            get => fields.ContactPersonMarriageAnniversary[this];
            set => fields.ContactPersonMarriageAnniversary[this] = value;
        }

        [DisplayName("Contact Person Birthdate"), Expression("jContactPerson.[Birthdate]")]
        public DateTime? ContactPersonBirthdate
        {
            get => fields.ContactPersonBirthdate[this];
            set => fields.ContactPersonBirthdate[this] = value;
        }

        [DisplayName("Contact Person Contacts Id"), Expression("jContactPerson.[ContactsId]")]
        public Int32? ContactPersonContactsId
        {
            get => fields.ContactPersonContactsId[this];
            set => fields.ContactPersonContactsId[this] = value;
        }

        [DisplayName("Contact Person Project"), Expression("jContactPerson.[Project]")]
        public String ContactPersonProject
        {
            get => fields.ContactPersonProject[this];
            set => fields.ContactPersonProject[this] = value;
        }

        [DisplayName("Contact Person Whatsapp"), Expression("jContactPerson.[Whatsapp]")]
        public String ContactPersonWhatsapp
        {
            get => fields.ContactPersonWhatsapp[this];
            set => fields.ContactPersonWhatsapp[this] = value;
        }

        [DisplayName("Contact Person Passport Number"), Expression("jContactPerson.[PassportNumber]")]
        public String ContactPersonPassportNumber
        {
            get => fields.ContactPersonPassportNumber[this];
            set => fields.ContactPersonPassportNumber[this] = value;
        }

        [DisplayName("Contact Person First Name"), Expression("jContactPerson.[FirstName]")]
        public String ContactPersonFirstName
        {
            get => fields.ContactPersonFirstName[this];
            set => fields.ContactPersonFirstName[this] = value;
        }

        [DisplayName("Contact Person Last Name"), Expression("jContactPerson.[LastName]")]
        public String ContactPersonLastName
        {
            get => fields.ContactPersonLastName[this];
            set => fields.ContactPersonLastName[this] = value;
        }

        [DisplayName("Contact Person Expiry Date"), Expression("jContactPerson.[ExpiryDate]")]
        public DateTime? ContactPersonExpiryDate
        {
            get => fields.ContactPersonExpiryDate[this];
            set => fields.ContactPersonExpiryDate[this] = value;
        }

        [DisplayName("Contact Person Aadhar No"), Expression("jContactPerson.[AadharNo]")]
        public String ContactPersonAadharNo
        {
            get => fields.ContactPersonAadharNo[this];
            set => fields.ContactPersonAadharNo[this] = value;
        }

        [DisplayName("Contact Person Pan No"), Expression("jContactPerson.[PANNo]")]
        public String ContactPersonPanNo
        {
            get => fields.ContactPersonPanNo[this];
            set => fields.ContactPersonPanNo[this] = value;
        }

        [DisplayName("Contact Person File Attachments"), Expression("jContactPerson.[FileAttachments]")]
        public String ContactPersonFileAttachments
        {
            get => fields.ContactPersonFileAttachments[this];
            set => fields.ContactPersonFileAttachments[this] = value;
        }
        [DisplayName("State"), Expression("(SELECT State FROM State WHERE Id= (SELECT Top (1) StateID FROM Contacts WHERE Id = t0.[ContactsId]))")]
        public String ContactsState
        {
            get { return Fields.ContactsState[this]; }
            set { Fields.ContactsState[this] = value; }
        }

        [DisplayName("Area"), Expression("(SELECT Area FROM Area WHERE Id= (SELECT Top (1) AreaID FROM Contacts WHERE Id = t0.[ContactsId]))")]
        public String ContactsArea
        {
            get { return Fields.ContactsArea[this]; }
            set { Fields.ContactsArea[this] = value; }
        }

        [DisplayName("City"), Expression("(SELECT City FROM City WHERE Id= (SELECT Top (1) CityID FROM Contacts WHERE Id = t0.[ContactsId]))")]
        public String ContactsCity
        {
            get { return Fields.ContactsCity[this]; }
            set { Fields.ContactsCity[this] = value; }
        }
        public MisInitialProcessRow()
            : base()
        {
        }

        public MisInitialProcessRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SrNo;
            public Int32Field RRSourceId;
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
            public StringField StageOfTheCase;
            public StringField SubInsurancePf;
            public Int32Field OwnerId;
            public Int32Field AssignedId;
            public StringField AdditionalInformation;
            public Int32Field ContactsId;
            public Int32Field ContactPersonId;

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
            public Int32Field LeadStageId;
            public StringField LeadStageName;
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

            public StringField ContactsState;
            public StringField ContactsCity;
            public StringField ContactsArea;

            public Int32Field ContactsContactType;
            public StringField ContactsName;
            public StringField ContactsPhone;
            public StringField ContactsEmail;
            public StringField ContactsAddress;
            public Int32Field ContactsCityId;
            public Int32Field ContactsStateId;
            public StringField ContactsPin;
            public Int32Field ContactsCountry;
            public StringField ContactsWebsite;
            public StringField ContactsAdditionalInfo;
            public StringField ContactsResidentialPhone;
            public StringField ContactsOfficePhone;
            public Int32Field ContactsGender;
            public Int32Field ContactsReligion;
            public Int32Field ContactsAreaId;
            public Int32Field ContactsMaritalStatus;
            public DateTimeField ContactsMarriageAnniversary;
            public DateTimeField ContactsBirthdate;
            public DateTimeField ContactsDateOfIncorporation;
            public Int32Field ContactsCategoryId;
            public Int32Field ContactsGradeId;
            public Int32Field ContactsType;
            public Int32Field ContactsOwnerId;
            public Int32Field ContactsAssignedId;
            public Int32Field ContactsChannelCategory;
            public Int32Field ContactsNationalDistributor;
            public Int32Field ContactsStockist;
            public Int32Field ContactsDistributor;
            public Int32Field ContactsDealer;
            public Int32Field ContactsWholesaler;
            public Int32Field ContactsReseller;
            public StringField ContactsGstin;
            public StringField ContactsPanNo;
            public StringField ContactsCcEmails;
            public StringField ContactsBccEmails;
            public StringField ContactsAttachment;
            public StringField ContactsEComGstin;
            public DoubleField ContactsCreditorsOpening;
            public DoubleField ContactsDebtorsOpening;
            public StringField ContactsBankName;
            public StringField ContactsAccountNumber;
            public StringField ContactsIfsc;
            public StringField ContactsBankType;
            public StringField ContactsBranch;
            public StringField ContactsAccountsEmail;
            public StringField ContactsPurchaseEmail;
            public StringField ContactsServiceEmail;
            public StringField ContactsSalesEmail;
            public Int32Field ContactsCreditDays;
            public Int32Field ContactsCustomerType;
            public Int32Field ContactsTrasportationId;
            public Int32Field ContactsTehsilId;
            public Int32Field ContactsVillageId;
            public StringField ContactsWhatsapp;
            public BooleanField ContactsConsentForCalling;
            public StringField ContactsAdditionalInfo2;
            public DateTimeField ContactsDateCreated;
            public StringField ContactsPassportNumber;
            public StringField ContactsFirstName;
            public StringField ContactsLastName;
            public DateTimeField ContactsExpiryDate;
            public StringField ContactsAadharNo;
            //public StringField ContactsCCEmails;
            //public StringField ContactsBCCEmails;
            public StringField ContactPersonName;
            public StringField ContactPersonPhone;
            public StringField ContactPersonResidentialPhone;
            public StringField ContactPersonEmail;
            public StringField ContactPersonDesignation;
            public StringField ContactPersonAddress;
            public Int32Field ContactPersonGender;
            public Int32Field ContactPersonReligion;
            public Int32Field ContactPersonMaritalStatus;
            public DateTimeField ContactPersonMarriageAnniversary;
            public DateTimeField ContactPersonBirthdate;
            public Int32Field ContactPersonContactsId;
            public StringField ContactPersonProject;
            public StringField ContactPersonWhatsapp;
            public StringField ContactPersonPassportNumber;
            public StringField ContactPersonFirstName;
            public StringField ContactPersonLastName;
            public DateTimeField ContactPersonExpiryDate;
            public StringField ContactPersonAadharNo;
            public StringField ContactPersonPanNo;
            public StringField ContactPersonFileAttachments;
            public Int32Field CustomerType;
        }
    }
}
