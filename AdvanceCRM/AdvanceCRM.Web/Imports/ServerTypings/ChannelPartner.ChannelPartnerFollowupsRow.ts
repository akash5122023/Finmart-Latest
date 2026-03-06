namespace AdvanceCRM.ChannelPartner {
    export interface ChannelPartnerFollowupsRow {
        Id?: number;
        FollowupNote?: string;
        Details?: string;
        FollowupDate?: string;
        Status?: Masters.StatusMaster;
        ChannelPartnerId?: number;
        RepresentativeId?: number;
        ClosingDate?: string;
        ChannelPartnerBankSalesManagerName?: string;
        RepresentativeDisplayName?: string;
    }

    export namespace ChannelPartnerFollowupsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FollowupNote';
        export const localTextPrefix = 'ChannelPartner.ChannelPartnerFollowups';
        export const deletePermission = 'ChannelPartner:Followups';
        export const insertPermission = 'ChannelPartner:Followups';
        export const readPermission = 'ChannelPartner:Read';
        export const updatePermission = 'ChannelPartner:Followups';

        export declare const enum Fields {
            Id = "Id",
            FollowupNote = "FollowupNote",
            Details = "Details",
            FollowupDate = "FollowupDate",
            Status = "Status",
            ChannelPartnerId = "ChannelPartnerId",
            RepresentativeId = "RepresentativeId",
            ClosingDate = "ClosingDate",
            ChannelPartnerBankSalesManagerName = "ChannelPartnerBankSalesManagerName",
            RepresentativeDisplayName = "RepresentativeDisplayName"
        }
    }
}
