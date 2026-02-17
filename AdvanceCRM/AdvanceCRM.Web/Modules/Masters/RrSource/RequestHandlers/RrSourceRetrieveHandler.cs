using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.RrSourceRow>;
using MyRow = AdvanceCRM.Masters.RrSourceRow;

namespace AdvanceCRM.Masters
{
    public interface IRrSourceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class RrSourceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRrSourceRetrieveHandler
    {
        public RrSourceRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}