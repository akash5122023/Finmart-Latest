using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Operations.MisLogInProcessRow>;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisLogInProcessRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisLogInProcessRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisLogInProcessRetrieveHandler
    {
        public MisLogInProcessRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}