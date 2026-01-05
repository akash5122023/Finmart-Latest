namespace AdvanceCRM.Masters {
    export interface TypesOfAccountsRow {
        Id?: number;
        AccountTypeName?: string;
    }

    export namespace TypesOfAccountsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'AccountTypeName';
        export const localTextPrefix = 'Masters.TypesOfAccounts';
        export const lookupKey = 'Masters.TypesOfAccounts';

        export function getLookup(): Q.Lookup<TypesOfAccountsRow> {
            return Q.getLookup<TypesOfAccountsRow>('Masters.TypesOfAccounts');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            AccountTypeName = "AccountTypeName"
        }
    }
}
