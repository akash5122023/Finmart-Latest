using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.ChannelPartner.ChannelPartnerRow>;
using MyRow = AdvanceCRM.ChannelPartner.ChannelPartnerRow;

namespace AdvanceCRM.ChannelPartner
{
    public interface IChannelPartnerRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChannelPartnerRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IChannelPartnerRetrieveHandler
    {
        public ChannelPartnerRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}