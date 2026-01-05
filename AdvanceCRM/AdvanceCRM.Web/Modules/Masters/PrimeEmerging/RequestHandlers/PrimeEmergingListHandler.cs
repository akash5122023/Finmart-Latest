using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.PrimeEmergingRow>;
using MyRow = AdvanceCRM.Masters.PrimeEmergingRow;

namespace AdvanceCRM.Masters
{
    public interface IPrimeEmergingListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PrimeEmergingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPrimeEmergingListHandler
    {
        public PrimeEmergingListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}