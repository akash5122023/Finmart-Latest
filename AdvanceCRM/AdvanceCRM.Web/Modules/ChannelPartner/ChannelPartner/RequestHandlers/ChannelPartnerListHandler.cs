using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.ChannelPartner.ChannelPartnerRow>;
using MyRow = AdvanceCRM.ChannelPartner.ChannelPartnerRow;

namespace AdvanceCRM.ChannelPartner
{
    public interface IChannelPartnerListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class ChannelPartnerListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IChannelPartnerListHandler
    {
        public ChannelPartnerListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}