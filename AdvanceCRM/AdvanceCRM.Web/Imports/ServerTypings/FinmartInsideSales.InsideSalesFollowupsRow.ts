namespace AdvanceCRM.FinmartInsideSales {
    export interface InsideSalesFollowupsRow {
        Id?: number;
        FollowupNote?: string;
        Details?: string;
        FollowupDate?: string;
        Status?: Masters.StatusMaster;
        InsideSalesId?: number;
        RepresentativeId?: number;
        ClosingDate?: string;
        InsideSalesSrNo?: string;
        RepresentativeDisplayName?: string;
    }

    export namespace InsideSalesFollowupsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'FollowupNote';
        export const localTextPrefix = 'FinmartInsideSales.InsideSalesFollowups';
        export const deletePermission = 'InsideSales:Followups';
        export const insertPermission = 'InsideSales:Followups';
        export const readPermission = 'InsideSales:Read';
        export const updatePermission = 'InsideSales:Followups';

        export declare const enum Fields {
            Id = "Id",
            FollowupNote = "FollowupNote",
            Details = "Details",
            FollowupDate = "FollowupDate",
            Status = "Status",
            InsideSalesId = "InsideSalesId",
            RepresentativeId = "RepresentativeId",
            ClosingDate = "ClosingDate",
            InsideSalesSrNo = "InsideSalesSrNo",
            RepresentativeDisplayName = "RepresentativeDisplayName"
        }
    }
}
