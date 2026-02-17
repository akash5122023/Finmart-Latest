using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.LeadStageRow>;
using MyRow = AdvanceCRM.Masters.LeadStageRow;

namespace AdvanceCRM.Masters
{
    public interface ILeadStageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStageListHandler
    {
        public LeadStageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}