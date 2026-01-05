namespace AdvanceCRM.Masters {
    export interface BankNameRow {
        Id?: number;
        BankNames?: string;
    }

    export namespace BankNameRow {
        export const idProperty = 'Id';
        export const nameProperty = 'BankNames';
        export const localTextPrefix = 'Masters.BankName';
        export const lookupKey = 'Masters.BankName';

        export function getLookup(): Q.Lookup<BankNameRow> {
            return Q.getLookup<BankNameRow>('Masters.BankName');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            BankNames = "BankNames"
        }
    }
}
