namespace AdvanceCRM.Masters {
    export interface CasesStageRow {
        Id?: number;
        CasesStageName?: string;
    }

    export namespace CasesStageRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CasesStageName';
        export const localTextPrefix = 'Masters.CasesStage';
        export const lookupKey = 'Masters.CasesStage';

        export function getLookup(): Q.Lookup<CasesStageRow> {
            return Q.getLookup<CasesStageRow>('Masters.CasesStage');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            CasesStageName = "CasesStageName"
        }
    }
}
