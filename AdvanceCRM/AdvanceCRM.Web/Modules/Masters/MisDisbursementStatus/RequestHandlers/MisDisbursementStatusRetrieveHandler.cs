using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.MisDisbursementStatusRow>;
using MyRow = AdvanceCRM.Masters.MisDisbursementStatusRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDisbursementStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementStatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementStatusRetrieveHandler
    {
        public MisDisbursementStatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}