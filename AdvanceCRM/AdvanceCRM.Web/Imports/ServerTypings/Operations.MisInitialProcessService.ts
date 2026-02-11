namespace AdvanceCRM.Operations {
    export namespace MisInitialProcessService {
        export const baseUrl = 'Operations/MisInitialProcess';

        export declare function Create(request: Serenity.SaveRequest<MisInitialProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<MisInitialProcessRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<MisInitialProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<MisInitialProcessRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ImportExcel(request: Serenity.ServiceRequest, onSuccess?: (response: Microsoft.AspNetCore.Mvc.IActionResult) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function MoveToLogInProcess(request: SendMailRequest, onSuccess?: (response: StandardResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "Operations/MisInitialProcess/Create",
            Update = "Operations/MisInitialProcess/Update",
            Delete = "Operations/MisInitialProcess/Delete",
            Retrieve = "Operations/MisInitialProcess/Retrieve",
            List = "Operations/MisInitialProcess/List",
            ImportExcel = "Operations/MisInitialProcess/ImportExcel",
            MoveToLogInProcess = "Operations/MisInitialProcess/MoveToLogInProcess"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ImportExcel', 
            'MoveToLogInProcess'
        ].forEach(x => {
            (<any>MisInitialProcessService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
