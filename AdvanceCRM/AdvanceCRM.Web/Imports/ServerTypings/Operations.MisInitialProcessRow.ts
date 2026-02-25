namespace AdvanceCRM.Operations {
    export interface MisInitialProcessRow {
        Id?: number;
        SrNo?: string;
        RRSourceId?: number;
        SourceName?: string;
        CustomerName?: string;
        FirmName?: string;
        BankSourceOrCompanyName?: string;
        FileHandledBy?: string;
        ContactPersonInTeam?: string;
        SalesManager?: string;
        Location?: string;
        ProductId?: number;
        Requirement?: string;
        NatureOfBusinessProfile?: string;
        ProfileOfTheLead?: string;
        BusinessVintage?: string;
        BusinessDetailId?: number;
        CompanyTypeId?: number;
        AccountTypeId?: number;
        FileReceivedDateTime?: string;
        QueriesGivenTime?: string;
        FileCompletionDateTime?: string;
        SystemLoginDate?: string;
        UnderwritingDate?: string;
        DisbursementDate?: string;
        Year?: string;
        MonthId?: number;
        BankNameId?: number;
        LoanAccountNumber?: string;
        PrimeEmergingId?: number;
        MisDirectIndirectId?: number;
        InhouseBankId?: number;
        LoanAmount?: number;
        Amount?: number;
        NetAmt?: number;
        AdvanceEmi?: number;
        ToPreviousYear?: number;
        ToLatestYear?: number;
        ContactNumber?: string;
        CompanyMailId?: string;
        EmployeeName?: string;
        ConfirmationMailTakenOrNot?: string;
        AgreementSigningPersonName?: string;
        LogInLoanStatusId?: number;
        SalesLoanStatusId?: number;
        MisDisbursementStatusId?: number;
        Remark?: string;
        StageOfTheCase?: string;
        SubInsurancePf?: string;
        OwnerId?: number;
        AssignedId?: number;
        AdditionalInformation?: string;
        ContactsId?: number;
        ContactPersonId?: number;
        ProductProductTypeName?: string;
        BusinessDetailBusinessDetailType?: string;
        CompanyTypeCompanyTypeName?: string;
        AccountTypeAccountTypeName?: string;
        MonthMonthsName?: string;
        BankNameBankNames?: string;
        PrimeEmergingPrimeEmergingName?: string;
        MisDirectIndirectMisDirectIndirectType?: string;
        InhouseBankInHouseBankType?: string;
        LogInLoanStatusLogInLoanStatusName?: string;
        SalesLoanStatusSalesLoanStatusName?: string;
        MisDisbursementStatusMisDisbursementStatusType?: string;
        OwnerUsername?: string;
        OwnerDisplayName?: string;
        OwnerEmail?: string;
        OwnerUpperLevel?: number;
        OwnerUpperLevel2?: number;
        OwnerUpperLevel3?: number;
        OwnerUpperLevel4?: number;
        OwnerUpperLevel5?: number;
        OwnerHost?: string;
        OwnerPort?: number;
        OwnerSsl?: boolean;
        OwnerEmailId?: string;
        OwnerEmailPassword?: string;
        OwnerPhone?: string;
        OwnerMcsmtpServer?: string;
        OwnerMcsmtpPort?: number;
        OwnerMcimapServer?: string;
        OwnerMcimapPort?: number;
        OwnerMcUsername?: string;
        OwnerMcPassword?: string;
        OwnerStartTime?: string;
        OwnerEndTime?: string;
        OwnerUid?: string;
        OwnerNonOperational?: boolean;
        OwnerBranchId?: number;
        OwnerCompanyId?: number;
        OwnerEnquiry?: boolean;
        OwnerQuotation?: boolean;
        OwnerTasks?: boolean;
        OwnerContacts?: boolean;
        OwnerPurchase?: boolean;
        OwnerSales?: boolean;
        OwnerCms?: boolean;
        OwnerLocation?: string;
        OwnerCoordinates?: string;
        OwnerTeamsId?: number;
        OwnerTenantId?: number;
        OwnerUrl?: string;
        OwnerPlan?: string;
        AssignedUsername?: string;
        AssignedDisplayName?: string;
        AssignedEmail?: string;
        AssignedUpperLevel?: number;
        LeadStageId?: number;
        LeadStageName?: string;
        AssignedUpperLevel2?: number;
        AssignedUpperLevel3?: number;
        AssignedUpperLevel4?: number;
        AssignedUpperLevel5?: number;
        AssignedHost?: string;
        AssignedPort?: number;
        AssignedSsl?: boolean;
        AssignedEmailId?: string;
        AssignedEmailPassword?: string;
        AssignedPhone?: string;
        AssignedMcsmtpServer?: string;
        AssignedMcsmtpPort?: number;
        AssignedMcimapServer?: string;
        AssignedMcimapPort?: number;
        AssignedMcUsername?: string;
        AssignedMcPassword?: string;
        AssignedStartTime?: string;
        AssignedEndTime?: string;
        AssignedUid?: string;
        AssignedNonOperational?: boolean;
        AssignedBranchId?: number;
        AssignedCompanyId?: number;
        AssignedEnquiry?: boolean;
        AssignedQuotation?: boolean;
        AssignedTasks?: boolean;
        AssignedContacts?: boolean;
        AssignedPurchase?: boolean;
        AssignedSales?: boolean;
        AssignedCms?: boolean;
        AssignedLocation?: string;
        AssignedCoordinates?: string;
        AssignedTeamsId?: number;
        AssignedTenantId?: number;
        AssignedUrl?: string;
        AssignedPlan?: string;
        ContactsState?: string;
        ContactsCity?: string;
        ContactsArea?: string;
        ContactsContactType?: number;
        ContactsName?: string;
        ContactsPhone?: string;
        ContactsEmail?: string;
        ContactsAddress?: string;
        ContactsCityId?: number;
        ContactsStateId?: number;
        ContactsPin?: string;
        ContactsCountry?: number;
        ContactsWebsite?: string;
        ContactsAdditionalInfo?: string;
        ContactsResidentialPhone?: string;
        ContactsOfficePhone?: string;
        ContactsGender?: number;
        ContactsReligion?: number;
        ContactsAreaId?: number;
        ContactsMaritalStatus?: number;
        ContactsMarriageAnniversary?: string;
        ContactsBirthdate?: string;
        ContactsDateOfIncorporation?: string;
        ContactsCategoryId?: number;
        ContactsGradeId?: number;
        ContactsType?: number;
        ContactsOwnerId?: number;
        ContactsAssignedId?: number;
        ContactsChannelCategory?: number;
        ContactsNationalDistributor?: number;
        ContactsStockist?: number;
        ContactsDistributor?: number;
        ContactsDealer?: number;
        ContactsWholesaler?: number;
        ContactsReseller?: number;
        ContactsGstin?: string;
        ContactsPanNo?: string;
        ContactsCcEmails?: string;
        ContactsBccEmails?: string;
        ContactsAttachment?: string;
        ContactsEComGstin?: string;
        ContactsCreditorsOpening?: number;
        ContactsDebtorsOpening?: number;
        ContactsBankName?: string;
        ContactsAccountNumber?: string;
        ContactsIfsc?: string;
        ContactsBankType?: string;
        ContactsBranch?: string;
        ContactsAccountsEmail?: string;
        ContactsPurchaseEmail?: string;
        ContactsServiceEmail?: string;
        ContactsSalesEmail?: string;
        ContactsCreditDays?: number;
        ContactsCustomerType?: number;
        ContactsTrasportationId?: number;
        ContactsTehsilId?: number;
        ContactsVillageId?: number;
        ContactsWhatsapp?: string;
        ContactsConsentForCalling?: boolean;
        ContactsAdditionalInfo2?: string;
        ContactsDateCreated?: string;
        ContactsPassportNumber?: string;
        ContactsFirstName?: string;
        ContactsLastName?: string;
        ContactsExpiryDate?: string;
        ContactsAadharNo?: string;
        ContactPersonName?: string;
        ContactPersonPhone?: string;
        ContactPersonResidentialPhone?: string;
        ContactPersonEmail?: string;
        ContactPersonDesignation?: string;
        ContactPersonAddress?: string;
        ContactPersonGender?: number;
        ContactPersonReligion?: number;
        ContactPersonMaritalStatus?: number;
        ContactPersonMarriageAnniversary?: string;
        ContactPersonBirthdate?: string;
        ContactPersonContactsId?: number;
        ContactPersonProject?: string;
        ContactPersonWhatsapp?: string;
        ContactPersonPassportNumber?: string;
        ContactPersonFirstName?: string;
        ContactPersonLastName?: string;
        ContactPersonExpiryDate?: string;
        ContactPersonAadharNo?: string;
        ContactPersonPanNo?: string;
        ContactPersonFileAttachments?: string;
        CustomerType?: Masters.ContactTypeMaster;
    }

    export namespace MisInitialProcessRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ContactsName';
        export const localTextPrefix = 'Operations.MisInitialProcess';
        export const lookupKey = 'Operations.MISInitialProcess';

        export function getLookup(): Q.Lookup<MisInitialProcessRow> {
            return Q.getLookup<MisInitialProcessRow>('Operations.MISInitialProcess');
        }
        export const deletePermission = 'MISInitialProcess:Delete';
        export const insertPermission = 'MISInitialProcess:Insert';
        export const readPermission = 'MISInitialProcess:Read';
        export const updatePermission = 'MISInitialProcess:Update';

        export declare const enum Fields {
            Id = "Id",
            SrNo = "SrNo",
            RRSourceId = "RRSourceId",
            SourceName = "SourceName",
            CustomerName = "CustomerName",
            FirmName = "FirmName",
            BankSourceOrCompanyName = "BankSourceOrCompanyName",
            FileHandledBy = "FileHandledBy",
            ContactPersonInTeam = "ContactPersonInTeam",
            SalesManager = "SalesManager",
            Location = "Location",
            ProductId = "ProductId",
            Requirement = "Requirement",
            NatureOfBusinessProfile = "NatureOfBusinessProfile",
            ProfileOfTheLead = "ProfileOfTheLead",
            BusinessVintage = "BusinessVintage",
            BusinessDetailId = "BusinessDetailId",
            CompanyTypeId = "CompanyTypeId",
            AccountTypeId = "AccountTypeId",
            FileReceivedDateTime = "FileReceivedDateTime",
            QueriesGivenTime = "QueriesGivenTime",
            FileCompletionDateTime = "FileCompletionDateTime",
            SystemLoginDate = "SystemLoginDate",
            UnderwritingDate = "UnderwritingDate",
            DisbursementDate = "DisbursementDate",
            Year = "Year",
            MonthId = "MonthId",
            BankNameId = "BankNameId",
            LoanAccountNumber = "LoanAccountNumber",
            PrimeEmergingId = "PrimeEmergingId",
            MisDirectIndirectId = "MisDirectIndirectId",
            InhouseBankId = "InhouseBankId",
            LoanAmount = "LoanAmount",
            Amount = "Amount",
            NetAmt = "NetAmt",
            AdvanceEmi = "AdvanceEmi",
            ToPreviousYear = "ToPreviousYear",
            ToLatestYear = "ToLatestYear",
            ContactNumber = "ContactNumber",
            CompanyMailId = "CompanyMailId",
            EmployeeName = "EmployeeName",
            ConfirmationMailTakenOrNot = "ConfirmationMailTakenOrNot",
            AgreementSigningPersonName = "AgreementSigningPersonName",
            LogInLoanStatusId = "LogInLoanStatusId",
            SalesLoanStatusId = "SalesLoanStatusId",
            MisDisbursementStatusId = "MisDisbursementStatusId",
            Remark = "Remark",
            StageOfTheCase = "StageOfTheCase",
            SubInsurancePf = "SubInsurancePf",
            OwnerId = "OwnerId",
            AssignedId = "AssignedId",
            AdditionalInformation = "AdditionalInformation",
            ContactsId = "ContactsId",
            ContactPersonId = "ContactPersonId",
            ProductProductTypeName = "ProductProductTypeName",
            BusinessDetailBusinessDetailType = "BusinessDetailBusinessDetailType",
            CompanyTypeCompanyTypeName = "CompanyTypeCompanyTypeName",
            AccountTypeAccountTypeName = "AccountTypeAccountTypeName",
            MonthMonthsName = "MonthMonthsName",
            BankNameBankNames = "BankNameBankNames",
            PrimeEmergingPrimeEmergingName = "PrimeEmergingPrimeEmergingName",
            MisDirectIndirectMisDirectIndirectType = "MisDirectIndirectMisDirectIndirectType",
            InhouseBankInHouseBankType = "InhouseBankInHouseBankType",
            LogInLoanStatusLogInLoanStatusName = "LogInLoanStatusLogInLoanStatusName",
            SalesLoanStatusSalesLoanStatusName = "SalesLoanStatusSalesLoanStatusName",
            MisDisbursementStatusMisDisbursementStatusType = "MisDisbursementStatusMisDisbursementStatusType",
            OwnerUsername = "OwnerUsername",
            OwnerDisplayName = "OwnerDisplayName",
            OwnerEmail = "OwnerEmail",
            OwnerUpperLevel = "OwnerUpperLevel",
            OwnerUpperLevel2 = "OwnerUpperLevel2",
            OwnerUpperLevel3 = "OwnerUpperLevel3",
            OwnerUpperLevel4 = "OwnerUpperLevel4",
            OwnerUpperLevel5 = "OwnerUpperLevel5",
            OwnerHost = "OwnerHost",
            OwnerPort = "OwnerPort",
            OwnerSsl = "OwnerSsl",
            OwnerEmailId = "OwnerEmailId",
            OwnerEmailPassword = "OwnerEmailPassword",
            OwnerPhone = "OwnerPhone",
            OwnerMcsmtpServer = "OwnerMcsmtpServer",
            OwnerMcsmtpPort = "OwnerMcsmtpPort",
            OwnerMcimapServer = "OwnerMcimapServer",
            OwnerMcimapPort = "OwnerMcimapPort",
            OwnerMcUsername = "OwnerMcUsername",
            OwnerMcPassword = "OwnerMcPassword",
            OwnerStartTime = "OwnerStartTime",
            OwnerEndTime = "OwnerEndTime",
            OwnerUid = "OwnerUid",
            OwnerNonOperational = "OwnerNonOperational",
            OwnerBranchId = "OwnerBranchId",
            OwnerCompanyId = "OwnerCompanyId",
            OwnerEnquiry = "OwnerEnquiry",
            OwnerQuotation = "OwnerQuotation",
            OwnerTasks = "OwnerTasks",
            OwnerContacts = "OwnerContacts",
            OwnerPurchase = "OwnerPurchase",
            OwnerSales = "OwnerSales",
            OwnerCms = "OwnerCms",
            OwnerLocation = "OwnerLocation",
            OwnerCoordinates = "OwnerCoordinates",
            OwnerTeamsId = "OwnerTeamsId",
            OwnerTenantId = "OwnerTenantId",
            OwnerUrl = "OwnerUrl",
            OwnerPlan = "OwnerPlan",
            AssignedUsername = "AssignedUsername",
            AssignedDisplayName = "AssignedDisplayName",
            AssignedEmail = "AssignedEmail",
            AssignedUpperLevel = "AssignedUpperLevel",
            LeadStageId = "LeadStageId",
            LeadStageName = "LeadStageName",
            AssignedUpperLevel2 = "AssignedUpperLevel2",
            AssignedUpperLevel3 = "AssignedUpperLevel3",
            AssignedUpperLevel4 = "AssignedUpperLevel4",
            AssignedUpperLevel5 = "AssignedUpperLevel5",
            AssignedHost = "AssignedHost",
            AssignedPort = "AssignedPort",
            AssignedSsl = "AssignedSsl",
            AssignedEmailId = "AssignedEmailId",
            AssignedEmailPassword = "AssignedEmailPassword",
            AssignedPhone = "AssignedPhone",
            AssignedMcsmtpServer = "AssignedMcsmtpServer",
            AssignedMcsmtpPort = "AssignedMcsmtpPort",
            AssignedMcimapServer = "AssignedMcimapServer",
            AssignedMcimapPort = "AssignedMcimapPort",
            AssignedMcUsername = "AssignedMcUsername",
            AssignedMcPassword = "AssignedMcPassword",
            AssignedStartTime = "AssignedStartTime",
            AssignedEndTime = "AssignedEndTime",
            AssignedUid = "AssignedUid",
            AssignedNonOperational = "AssignedNonOperational",
            AssignedBranchId = "AssignedBranchId",
            AssignedCompanyId = "AssignedCompanyId",
            AssignedEnquiry = "AssignedEnquiry",
            AssignedQuotation = "AssignedQuotation",
            AssignedTasks = "AssignedTasks",
            AssignedContacts = "AssignedContacts",
            AssignedPurchase = "AssignedPurchase",
            AssignedSales = "AssignedSales",
            AssignedCms = "AssignedCms",
            AssignedLocation = "AssignedLocation",
            AssignedCoordinates = "AssignedCoordinates",
            AssignedTeamsId = "AssignedTeamsId",
            AssignedTenantId = "AssignedTenantId",
            AssignedUrl = "AssignedUrl",
            AssignedPlan = "AssignedPlan",
            ContactsState = "ContactsState",
            ContactsCity = "ContactsCity",
            ContactsArea = "ContactsArea",
            ContactsContactType = "ContactsContactType",
            ContactsName = "ContactsName",
            ContactsPhone = "ContactsPhone",
            ContactsEmail = "ContactsEmail",
            ContactsAddress = "ContactsAddress",
            ContactsCityId = "ContactsCityId",
            ContactsStateId = "ContactsStateId",
            ContactsPin = "ContactsPin",
            ContactsCountry = "ContactsCountry",
            ContactsWebsite = "ContactsWebsite",
            ContactsAdditionalInfo = "ContactsAdditionalInfo",
            ContactsResidentialPhone = "ContactsResidentialPhone",
            ContactsOfficePhone = "ContactsOfficePhone",
            ContactsGender = "ContactsGender",
            ContactsReligion = "ContactsReligion",
            ContactsAreaId = "ContactsAreaId",
            ContactsMaritalStatus = "ContactsMaritalStatus",
            ContactsMarriageAnniversary = "ContactsMarriageAnniversary",
            ContactsBirthdate = "ContactsBirthdate",
            ContactsDateOfIncorporation = "ContactsDateOfIncorporation",
            ContactsCategoryId = "ContactsCategoryId",
            ContactsGradeId = "ContactsGradeId",
            ContactsType = "ContactsType",
            ContactsOwnerId = "ContactsOwnerId",
            ContactsAssignedId = "ContactsAssignedId",
            ContactsChannelCategory = "ContactsChannelCategory",
            ContactsNationalDistributor = "ContactsNationalDistributor",
            ContactsStockist = "ContactsStockist",
            ContactsDistributor = "ContactsDistributor",
            ContactsDealer = "ContactsDealer",
            ContactsWholesaler = "ContactsWholesaler",
            ContactsReseller = "ContactsReseller",
            ContactsGstin = "ContactsGstin",
            ContactsPanNo = "ContactsPanNo",
            ContactsCcEmails = "ContactsCcEmails",
            ContactsBccEmails = "ContactsBccEmails",
            ContactsAttachment = "ContactsAttachment",
            ContactsEComGstin = "ContactsEComGstin",
            ContactsCreditorsOpening = "ContactsCreditorsOpening",
            ContactsDebtorsOpening = "ContactsDebtorsOpening",
            ContactsBankName = "ContactsBankName",
            ContactsAccountNumber = "ContactsAccountNumber",
            ContactsIfsc = "ContactsIfsc",
            ContactsBankType = "ContactsBankType",
            ContactsBranch = "ContactsBranch",
            ContactsAccountsEmail = "ContactsAccountsEmail",
            ContactsPurchaseEmail = "ContactsPurchaseEmail",
            ContactsServiceEmail = "ContactsServiceEmail",
            ContactsSalesEmail = "ContactsSalesEmail",
            ContactsCreditDays = "ContactsCreditDays",
            ContactsCustomerType = "ContactsCustomerType",
            ContactsTrasportationId = "ContactsTrasportationId",
            ContactsTehsilId = "ContactsTehsilId",
            ContactsVillageId = "ContactsVillageId",
            ContactsWhatsapp = "ContactsWhatsapp",
            ContactsConsentForCalling = "ContactsConsentForCalling",
            ContactsAdditionalInfo2 = "ContactsAdditionalInfo2",
            ContactsDateCreated = "ContactsDateCreated",
            ContactsPassportNumber = "ContactsPassportNumber",
            ContactsFirstName = "ContactsFirstName",
            ContactsLastName = "ContactsLastName",
            ContactsExpiryDate = "ContactsExpiryDate",
            ContactsAadharNo = "ContactsAadharNo",
            ContactPersonName = "ContactPersonName",
            ContactPersonPhone = "ContactPersonPhone",
            ContactPersonResidentialPhone = "ContactPersonResidentialPhone",
            ContactPersonEmail = "ContactPersonEmail",
            ContactPersonDesignation = "ContactPersonDesignation",
            ContactPersonAddress = "ContactPersonAddress",
            ContactPersonGender = "ContactPersonGender",
            ContactPersonReligion = "ContactPersonReligion",
            ContactPersonMaritalStatus = "ContactPersonMaritalStatus",
            ContactPersonMarriageAnniversary = "ContactPersonMarriageAnniversary",
            ContactPersonBirthdate = "ContactPersonBirthdate",
            ContactPersonContactsId = "ContactPersonContactsId",
            ContactPersonProject = "ContactPersonProject",
            ContactPersonWhatsapp = "ContactPersonWhatsapp",
            ContactPersonPassportNumber = "ContactPersonPassportNumber",
            ContactPersonFirstName = "ContactPersonFirstName",
            ContactPersonLastName = "ContactPersonLastName",
            ContactPersonExpiryDate = "ContactPersonExpiryDate",
            ContactPersonAadharNo = "ContactPersonAadharNo",
            ContactPersonPanNo = "ContactPersonPanNo",
            ContactPersonFileAttachments = "ContactPersonFileAttachments",
            CustomerType = "CustomerType"
        }
    }
}
