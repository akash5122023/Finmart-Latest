using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Operations.MisLogInProcessRow>;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisLogInProcessListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisLogInProcessListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisLogInProcessListHandler
    {
        public MisLogInProcessListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}