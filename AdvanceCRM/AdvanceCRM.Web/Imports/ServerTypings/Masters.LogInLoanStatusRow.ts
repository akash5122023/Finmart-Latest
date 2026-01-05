namespace AdvanceCRM.Masters {
    export interface LogInLoanStatusRow {
        Id?: number;
        LogInLoanStatusName?: string;
    }

    export namespace LogInLoanStatusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'LogInLoanStatusName';
        export const localTextPrefix = 'Masters.LogInLoanStatus';
        export const lookupKey = 'Masters.LogInLoanStatus';

        export function getLookup(): Q.Lookup<LogInLoanStatusRow> {
            return Q.getLookup<LogInLoanStatusRow>('Masters.LogInLoanStatus');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            LogInLoanStatusName = "LogInLoanStatusName"
        }
    }
}
