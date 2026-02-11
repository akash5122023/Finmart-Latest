namespace AdvanceCRM.FinmartInsideSales {
    export namespace InsideSalesService {
        export const baseUrl = 'FinmartInsideSales/InsideSales';

        export declare function Create(request: Serenity.SaveRequest<InsideSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<InsideSalesRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<InsideSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<InsideSalesRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ImportExcel(request: Serenity.ServiceRequest, onSuccess?: (response: Microsoft.AspNetCore.Mvc.IActionResult) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function MoveToInitialProcess(request: SendMailRequest, onSuccess?: (response: StandardResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "FinmartInsideSales/InsideSales/Create",
            Update = "FinmartInsideSales/InsideSales/Update",
            Delete = "FinmartInsideSales/InsideSales/Delete",
            Retrieve = "FinmartInsideSales/InsideSales/Retrieve",
            List = "FinmartInsideSales/InsideSales/List",
            ImportExcel = "FinmartInsideSales/InsideSales/ImportExcel",
            MoveToInitialProcess = "FinmartInsideSales/InsideSales/MoveToInitialProcess"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ImportExcel', 
            'MoveToInitialProcess'
        ].forEach(x => {
            (<any>InsideSalesService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
