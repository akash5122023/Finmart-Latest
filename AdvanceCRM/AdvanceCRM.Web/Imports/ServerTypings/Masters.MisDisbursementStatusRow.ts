namespace AdvanceCRM.Masters {
    export interface MisDisbursementStatusRow {
        Id?: number;
        MisDisbursementStatusType?: string;
    }

    export namespace MisDisbursementStatusRow {
        export const idProperty = 'Id';
        export const nameProperty = 'MisDisbursementStatusType';
        export const localTextPrefix = 'Masters.MisDisbursementStatus';
        export const lookupKey = 'Masters.MISDisbursementStatus';

        export function getLookup(): Q.Lookup<MisDisbursementStatusRow> {
            return Q.getLookup<MisDisbursementStatusRow>('Masters.MISDisbursementStatus');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            MisDisbursementStatusType = "MisDisbursementStatusType"
        }
    }
}
