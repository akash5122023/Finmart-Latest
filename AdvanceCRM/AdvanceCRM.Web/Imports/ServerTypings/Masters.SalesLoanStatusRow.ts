namespace AdvanceCRM.Masters {
    export interface SalesLoanStatusRow {
        Id?: number;
        SalesLoanStatusName?: string;
    }

    export namespace SalesLoanStatusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SalesLoanStatusName';
        export const localTextPrefix = 'Masters.SalesLoanStatus';
        export const lookupKey = 'Masters.SalesLoanStatus';

        export function getLookup(): Q.Lookup<SalesLoanStatusRow> {
            return Q.getLookup<SalesLoanStatusRow>('Masters.SalesLoanStatus');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            SalesLoanStatusName = "SalesLoanStatusName"
        }
    }
}
