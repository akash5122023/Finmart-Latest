using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.ChannelPartner.ChannelPartnerRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.ChannelPartner.ChannelPartnerRow;

namespace AdvanceCRM.ChannelPartner
{
    public interface IChannelPartnerSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class ChannelPartnerSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IChannelPartnerSaveHandler
    {
        public ChannelPartnerSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}