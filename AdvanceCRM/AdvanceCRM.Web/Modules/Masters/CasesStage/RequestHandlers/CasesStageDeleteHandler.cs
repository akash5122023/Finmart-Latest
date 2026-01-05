using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.CasesStageRow;

namespace AdvanceCRM.Masters
{
    public interface ICasesStageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CasesStageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICasesStageDeleteHandler
    {
        public CasesStageDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}