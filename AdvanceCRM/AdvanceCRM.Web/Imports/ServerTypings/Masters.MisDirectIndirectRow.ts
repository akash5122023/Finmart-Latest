namespace AdvanceCRM.Masters {
    export interface MisDirectIndirectRow {
        Id?: number;
        MisDirectIndirectType?: string;
    }

    export namespace MisDirectIndirectRow {
        export const idProperty = 'Id';
        export const nameProperty = 'MisDirectIndirectType';
        export const localTextPrefix = 'Masters.MisDirectIndirect';
        export const lookupKey = 'Masters.MISDirectIndirect';

        export function getLookup(): Q.Lookup<MisDirectIndirectRow> {
            return Q.getLookup<MisDirectIndirectRow>('Masters.MISDirectIndirect');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            MisDirectIndirectType = "MisDirectIndirectType"
        }
    }
}
