namespace AdvanceCRM.Masters {
    export interface LeadStageRow {
        Id?: number;
        LeadStageName?: string;
    }

    export namespace LeadStageRow {
        export const idProperty = 'Id';
        export const nameProperty = 'LeadStageName';
        export const localTextPrefix = 'Masters.LeadStage';
        export const lookupKey = 'Masters.LeadStage';

        export function getLookup(): Q.Lookup<LeadStageRow> {
            return Q.getLookup<LeadStageRow>('Masters.LeadStage');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            LeadStageName = "LeadStageName"
        }
    }
}
