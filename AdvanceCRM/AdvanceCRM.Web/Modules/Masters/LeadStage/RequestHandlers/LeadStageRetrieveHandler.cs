using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.LeadStageRow>;
using MyRow = AdvanceCRM.Masters.LeadStageRow;

namespace AdvanceCRM.Masters
{
    public interface ILeadStageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStageRetrieveHandler
    {
        public LeadStageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}