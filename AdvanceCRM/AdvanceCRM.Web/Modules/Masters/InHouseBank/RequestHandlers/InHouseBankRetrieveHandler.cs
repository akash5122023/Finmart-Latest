using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.InHouseBankRow>;
using MyRow = AdvanceCRM.Masters.InHouseBankRow;

namespace AdvanceCRM.Masters
{
    public interface IInHouseBankRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class InHouseBankRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInHouseBankRetrieveHandler
    {
        public InHouseBankRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}