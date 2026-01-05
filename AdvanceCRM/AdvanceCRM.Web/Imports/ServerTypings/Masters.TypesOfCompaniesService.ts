namespace AdvanceCRM.Masters {
    export namespace TypesOfCompaniesService {
        export const baseUrl = 'Masters/TypesOfCompanies';

        export declare function Create(request: Serenity.SaveRequest<TypesOfCompaniesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<TypesOfCompaniesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TypesOfCompaniesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TypesOfCompaniesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Masters/TypesOfCompanies/Create",
            Update = "Masters/TypesOfCompanies/Update",
            Delete = "Masters/TypesOfCompanies/Delete",
            Retrieve = "Masters/TypesOfCompanies/Retrieve",
            List = "Masters/TypesOfCompanies/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>TypesOfCompaniesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
