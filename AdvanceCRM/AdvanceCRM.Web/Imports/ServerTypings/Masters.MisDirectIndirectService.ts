namespace AdvanceCRM.Masters {
    export namespace MisDirectIndirectService {
        export const baseUrl = 'Masters/MisDirectIndirect';

        export declare function Create(request: Serenity.SaveRequest<MisDirectIndirectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MisDirectIndirectRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MisDirectIndirectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MisDirectIndirectRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Masters/MisDirectIndirect/Create",
            Update = "Masters/MisDirectIndirect/Update",
            Delete = "Masters/MisDirectIndirect/Delete",
            Retrieve = "Masters/MisDirectIndirect/Retrieve",
            List = "Masters/MisDirectIndirect/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>MisDirectIndirectService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
