namespace AdvanceCRM.Masters {
    export interface BusinessDetailsRow {
        Id?: number;
        BusinessDetailType?: string;
    }

    export namespace BusinessDetailsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BusinessDetailType';
        export const localTextPrefix = 'Masters.BusinessDetails';
        export const lookupKey = 'Masters.BusinessDetails';

        export function getLookup(): Q.Lookup<BusinessDetailsRow> {
            return Q.getLookup<BusinessDetailsRow>('Masters.BusinessDetails');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            BusinessDetailType = "BusinessDetailType"
        }
    }
}
