using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.ChannelPartner.ChannelPartnerRow;

namespace AdvanceCRM.ChannelPartner
{
    public interface IChannelPartnerDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class ChannelPartnerDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IChannelPartnerDeleteHandler
    {
        public ChannelPartnerDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}