using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Operations.MisInitialProcessRow>;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessRetrieveHandler
    {
        public MisInitialProcessRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}