using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.CasesStageRow>;
using MyRow = AdvanceCRM.Masters.CasesStageRow;

namespace AdvanceCRM.Masters
{
    public interface ICasesStageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CasesStageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICasesStageRetrieveHandler
    {
        public CasesStageRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}