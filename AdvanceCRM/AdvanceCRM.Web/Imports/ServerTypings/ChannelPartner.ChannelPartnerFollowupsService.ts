namespace AdvanceCRM.ChannelPartner {
    export namespace ChannelPartnerFollowupsService {
        export const baseUrl = 'ChannelPartner/ChannelPartnerFollowups';

        export declare function Create(request: Serenity.SaveRequest<ChannelPartnerFollowupsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ChannelPartnerFollowupsRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ChannelPartnerFollowupsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ChannelPartnerFollowupsRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export declare const enum Methods {
            Create = "ChannelPartner/ChannelPartnerFollowups/Create",
            Update = "ChannelPartner/ChannelPartnerFollowups/Update",
            Delete = "ChannelPartner/ChannelPartnerFollowups/Delete",
            Retrieve = "ChannelPartner/ChannelPartnerFollowups/Retrieve",
            List = "ChannelPartner/ChannelPartnerFollowups/List"
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>ChannelPartnerFollowupsService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
        });
    }
}
