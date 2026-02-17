using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.LeadStageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.LeadStageRow;

namespace AdvanceCRM.Masters
{
    public interface ILeadStageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class LeadStageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILeadStageSaveHandler
    {
        public LeadStageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}