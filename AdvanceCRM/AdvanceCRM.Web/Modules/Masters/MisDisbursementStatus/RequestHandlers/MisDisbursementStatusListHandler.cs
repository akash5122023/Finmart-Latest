using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.MisDisbursementStatusRow>;
using MyRow = AdvanceCRM.Masters.MisDisbursementStatusRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDisbursementStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementStatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementStatusListHandler
    {
        public MisDisbursementStatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}