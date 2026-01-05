using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessDeleteHandler
    {
        public MisInitialProcessDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}