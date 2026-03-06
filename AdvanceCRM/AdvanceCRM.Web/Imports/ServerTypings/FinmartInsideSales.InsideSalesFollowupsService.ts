namespace AdvanceCRM.FinmartInsideSales {
    export namespace InsideSalesFollowupsService {
        export const baseUrl = 'FinmartInsideSales/InsideSalesFollowups';

        export declare function Create(request: Serenity.SaveRequest<InsideSalesFollowupsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<InsideSalesFollowupsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InsideSalesFollowupsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InsideSalesFollowupsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "FinmartInsideSales/InsideSalesFollowups/Create",
            Update = "FinmartInsideSales/InsideSalesFollowups/Update",
            Delete = "FinmartInsideSales/InsideSalesFollowups/Delete",
            Retrieve = "FinmartInsideSales/InsideSalesFollowups/Retrieve",
            List = "FinmartInsideSales/InsideSalesFollowups/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>InsideSalesFollowupsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
