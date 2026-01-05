using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisLogInProcessDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MisLogInProcessDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMisLogInProcessDeleteHandler
    {
        public MisLogInProcessDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}