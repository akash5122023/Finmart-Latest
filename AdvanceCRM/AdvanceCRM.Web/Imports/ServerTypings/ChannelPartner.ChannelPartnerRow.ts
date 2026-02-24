namespace AdvanceCRM.ChannelPartner {
    export interface ChannelPartnerRow {
        Id?: number;
        BankNameId?: number;
        BankSalesManagerName?: string;
        ProductId?: number;
        LoanAmount?: number;
        LoginDate?: string;
        MisDisbursementStatusId?: number;
        DisbursementDate?: string;
        DisbursedAmount?: number;
        OwnerId?: number;
        BankNameBankNames?: string;
        ProductProductTypeName?: string;
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
    }

    export namespace ChannelPartnerRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BankSalesManagerName';
        export const localTextPrefix = 'ChannelPartner.ChannelPartner';
        export const lookupKey = 'ChannelPartner.ChannelPartner';

        export function getLookup(): Q.Lookup<ChannelPartnerRow> {
            return Q.getLookup<ChannelPartnerRow>('ChannelPartner.ChannelPartner');
        }
        export const deletePermission = 'ChannelPartner:Delete';
        export const insertPermission = 'ChannelPartner:Insert';
        export const readPermission = 'ChannelPartner:Read';
        export const updatePermission = 'ChannelPartner:Update';

        export declare const enum Fields {
            Id = "Id",
            BankNameId = "BankNameId",
            BankSalesManagerName = "BankSalesManagerName",
            ProductId = "ProductId",
            LoanAmount = "LoanAmount",
            LoginDate = "LoginDate",
            MisDisbursementStatusId = "MisDisbursementStatusId",
            DisbursementDate = "DisbursementDate",
            DisbursedAmount = "DisbursedAmount",
            OwnerId = "OwnerId",
            BankNameBankNames = "BankNameBankNames",
            ProductProductTypeName = "ProductProductTypeName",
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
            OwnerPlan = "OwnerPlan"
        }
    }
}
