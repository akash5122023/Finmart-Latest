namespace AdvanceCRM.Operations {
    export namespace MisDisbursementProcessService {
        export const baseUrl = 'Operations/MisDisbursementProcess';

        export declare function Create(request: Serenity.SaveRequest<MisDisbursementProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MisDisbursementProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MisDisbursementProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MisDisbursementProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ImportExcel(request: Serenity.ServiceRequest, onSuccess?: (response: Microsoft.AspNetCore.Mvc.IActionResult) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Operations/MisDisbursementProcess/Create",
            Update = "Operations/MisDisbursementProcess/Update",
            Delete = "Operations/MisDisbursementProcess/Delete",
            Retrieve = "Operations/MisDisbursementProcess/Retrieve",
            List = "Operations/MisDisbursementProcess/List",
            ImportExcel = "Operations/MisDisbursementProcess/ImportExcel"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ImportExcel'
        ].forEach(x => {
            (<any>MisDisbursementProcessService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
