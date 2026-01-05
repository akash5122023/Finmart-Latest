using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.PrimeEmergingRow>;
using MyRow = AdvanceCRM.Masters.PrimeEmergingRow;

namespace AdvanceCRM.Masters
{
    public interface IPrimeEmergingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class PrimeEmergingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPrimeEmergingRetrieveHandler
    {
        public PrimeEmergingRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}