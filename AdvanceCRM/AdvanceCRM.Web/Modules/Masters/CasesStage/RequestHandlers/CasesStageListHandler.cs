using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.CasesStageRow>;
using MyRow = AdvanceCRM.Masters.CasesStageRow;

namespace AdvanceCRM.Masters
{
    public interface ICasesStageListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CasesStageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICasesStageListHandler
    {
        public CasesStageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}