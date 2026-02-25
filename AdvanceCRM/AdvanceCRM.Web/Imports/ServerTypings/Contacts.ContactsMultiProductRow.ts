namespace AdvanceCRM.Contacts {
    export interface ContactsMultiProductRow {
        Id?: number;
        ProductId?: number;
        ContactsId?: number;
        ProductTypeName?: string;
        ContactsName?: string;
    }

    export namespace ContactsMultiProductRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'Contacts.ContactsMultiProduct';
        export const deletePermission = 'Contacts:Delete';
        export const insertPermission = 'Contacts:Insert';
        export const readPermission = 'Contacts:Read';
        export const updatePermission = 'Contacts:Update';

        export declare const enum Fields {
            Id = "Id",
            ProductId = "ProductId",
            ContactsId = "ContactsId",
            ProductTypeName = "ProductTypeName",
            ContactsName = "ContactsName"
        }
    }
}
