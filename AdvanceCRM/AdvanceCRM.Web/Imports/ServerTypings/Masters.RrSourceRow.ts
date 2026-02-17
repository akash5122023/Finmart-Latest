namespace AdvanceCRM.Masters {
    export interface RrSourceRow {
        Id?: number;
        SourceName?: string;
    }

    export namespace RrSourceRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SourceName';
        export const localTextPrefix = 'Masters.RrSource';
        export const lookupKey = 'Masters.RRSource';

        export function getLookup(): Q.Lookup<RrSourceRow> {
            return Q.getLookup<RrSourceRow>('Masters.RRSource');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            SourceName = "SourceName"
        }
    }
}
