namespace AdvanceCRM.ChannelPartner {
    export namespace ChannelPartnerService {
        export const baseUrl = 'ChannelPartner/ChannelPartner';

        export declare function Create(request: Serenity.SaveRequest<ChannelPartnerRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ChannelPartnerRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ChannelPartnerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ChannelPartnerRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ChannelPartner/ChannelPartner/Create",
            Update = "ChannelPartner/ChannelPartner/Update",
            Delete = "ChannelPartner/ChannelPartner/Delete",
            Retrieve = "ChannelPartner/ChannelPartner/Retrieve",
            List = "ChannelPartner/ChannelPartner/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ChannelPartnerService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
