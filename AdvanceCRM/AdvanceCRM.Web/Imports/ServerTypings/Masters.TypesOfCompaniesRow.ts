namespace AdvanceCRM.Masters {
    export interface TypesOfCompaniesRow {
        Id?: number;
        CompanyTypeName?: string;
    }

    export namespace TypesOfCompaniesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CompanyTypeName';
        export const localTextPrefix = 'Masters.TypesOfCompanies';
        export const lookupKey = 'Masters.TypesOfCompanies';

        export function getLookup(): Q.Lookup<TypesOfCompaniesRow> {
            return Q.getLookup<TypesOfCompaniesRow>('Masters.TypesOfCompanies');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            CompanyTypeName = "CompanyTypeName"
        }
    }
}
