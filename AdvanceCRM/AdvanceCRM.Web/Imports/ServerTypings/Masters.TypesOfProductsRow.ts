namespace AdvanceCRM.Masters {
    export interface TypesOfProductsRow {
        Id?: number;
        ProductTypeName?: string;
    }

    export namespace TypesOfProductsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ProductTypeName';
        export const localTextPrefix = 'Masters.TypesOfProducts';
        export const lookupKey = 'Masters.TypesOfProducts';

        export function getLookup(): Q.Lookup<TypesOfProductsRow> {
            return Q.getLookup<TypesOfProductsRow>('Masters.TypesOfProducts');
        }
        export const deletePermission = 'Masters:Modify';
        export const insertPermission = 'Masters:Modify';
        export const readPermission = 'Masters:Read';
        export const updatePermission = 'Masters:Modify';

        export declare const enum Fields {
            Id = "Id",
            ProductTypeName = "ProductTypeName"
        }
    }
}
