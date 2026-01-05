namespace AdvanceCRM.Masters {
    export interface InHouseBankRow {
        Id?: number;
        InHouseBankType?: string;
    }

    export namespace InHouseBankRow {
        export const idProperty = 'Id';
        export const nameProperty = 'InHouseBankType';
        export const localTextPrefix = 'Masters.InHouseBank';
        export const lookupKey = 'Masters.InHouseBank';

        export function getLookup(): Q.Lookup<InHouseBankRow> {
            return Q.getLookup<InHouseBankRow>('Masters.InHouseBank');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            InHouseBankType = "InHouseBankType"
        }
    }
}
