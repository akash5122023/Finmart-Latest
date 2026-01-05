using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Operations.MisDisbursementProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisDisbursementProcessDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementProcessDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementProcessDeleteHandler
    {
        public MisDisbursementProcessDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}