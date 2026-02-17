namespace AdvanceCRM.Masters {
    export interface CustomerApprovalRow {
        Id?: number;
        CustomerApprovalType?: string;
    }

    export namespace CustomerApprovalRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CustomerApprovalType';
        export const localTextPrefix = 'Masters.CustomerApproval';
        export const lookupKey = 'Masters.CustomerApproval';

        export function getLookup(): Q.Lookup<CustomerApprovalRow> {
            return Q.getLookup<CustomerApprovalRow>('Masters.CustomerApproval');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            CustomerApprovalType = "CustomerApprovalType"
        }
    }
}
