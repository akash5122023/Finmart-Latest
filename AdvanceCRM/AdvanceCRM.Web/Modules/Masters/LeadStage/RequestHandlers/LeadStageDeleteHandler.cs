using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.LeadStageRow;

namespace AdvanceCRM.Masters
{
    public interface ILeadStageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStageDeleteHandler
    {
        public LeadStageDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}