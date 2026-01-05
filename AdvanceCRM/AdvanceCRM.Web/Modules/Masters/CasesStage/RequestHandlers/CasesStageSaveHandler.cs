using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.CasesStageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.CasesStageRow;

namespace AdvanceCRM.Masters
{
    public interface ICasesStageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CasesStageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICasesStageSaveHandler
    {
        public CasesStageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}