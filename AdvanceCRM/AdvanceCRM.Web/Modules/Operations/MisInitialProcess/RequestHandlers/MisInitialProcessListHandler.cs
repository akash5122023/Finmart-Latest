using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Operations.MisInitialProcessRow>;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessListHandler
    {
        public MisInitialProcessListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}