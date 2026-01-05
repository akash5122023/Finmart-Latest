using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Operations.MisDisbursementProcessRow>;
using MyRow = AdvanceCRM.Operations.MisDisbursementProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisDisbursementProcessListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementProcessListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementProcessListHandler
    {
        public MisDisbursementProcessListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}