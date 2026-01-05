using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.MisDirectIndirectRow>;
using MyRow = AdvanceCRM.Masters.MisDirectIndirectRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDirectIndirectRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDirectIndirectRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDirectIndirectRetrieveHandler
    {
        public MisDirectIndirectRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}