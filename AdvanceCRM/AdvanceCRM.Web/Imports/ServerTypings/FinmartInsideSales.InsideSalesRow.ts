namespace AdvanceCRM.FinmartInsideSales {
    export interface InsideSalesRow {
        Id?: number;
        SrNo?: string;
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
        StageOfTheCaseId?: number;
        SubInsurancePf?: string;
        OwnerId?: number;
        AssignedId?: number;
        AdditionalInformation?: string;
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
        StageOfTheCaseCasesStageName?: string;
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
    }

    export namespace InsideSalesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SrNo';
        export const localTextPrefix = 'FinmartInsideSales.InsideSales';
        export const lookupKey = 'FinmartInsideSales.InsideSales';

        export function getLookup(): Q.Lookup<InsideSalesRow> {
            return Q.getLookup<InsideSalesRow>('FinmartInsideSales.InsideSales');
        }
        export const deletePermission = 'InsideSales:Delete';
        export const insertPermission = 'InsideSales:Insert';
        export const readPermission = 'InsideSales:Read';
        export const updatePermission = 'InsideSales:Update';

        export declare const enum Fields {
            Id = "Id",
            SrNo = "SrNo",
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
            StageOfTheCaseId = "StageOfTheCaseId",
            SubInsurancePf = "SubInsurancePf",
            OwnerId = "OwnerId",
            AssignedId = "AssignedId",
            AdditionalInformation = "AdditionalInformation",
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
            StageOfTheCaseCasesStageName = "StageOfTheCaseCasesStageName",
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
            AssignedPlan = "AssignedPlan"
        }
    }
}
