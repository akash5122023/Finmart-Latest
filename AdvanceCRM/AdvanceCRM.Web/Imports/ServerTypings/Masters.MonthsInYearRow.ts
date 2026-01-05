namespace AdvanceCRM.Masters {
    export interface MonthsInYearRow {
        Id?: number;
        MonthsName?: string;
    }

    export namespace MonthsInYearRow {
        export const idProperty = 'Id';
        export const nameProperty = 'MonthsName';
        export const localTextPrefix = 'Masters.MonthsInYear';
        export const lookupKey = 'Masters.MonthsInYear';

        export function getLookup(): Q.Lookup<MonthsInYearRow> {
            return Q.getLookup<MonthsInYearRow>('Masters.MonthsInYear');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            MonthsName = "MonthsName"
        }
    }
}
