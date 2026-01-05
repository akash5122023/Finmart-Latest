namespace AdvanceCRM.Masters {
    export interface PrimeEmergingRow {
        Id?: number;
        PrimeEmergingName?: string;
    }

    export namespace PrimeEmergingRow {
        export const idProperty = 'Id';
        export const nameProperty = 'PrimeEmergingName';
        export const localTextPrefix = 'Masters.PrimeEmerging';
        export const lookupKey = 'Masters.PrimeEmerging';

        export function getLookup(): Q.Lookup<PrimeEmergingRow> {
            return Q.getLookup<PrimeEmergingRow>('Masters.PrimeEmerging');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            PrimeEmergingName = "PrimeEmergingName"
        }
    }
}
