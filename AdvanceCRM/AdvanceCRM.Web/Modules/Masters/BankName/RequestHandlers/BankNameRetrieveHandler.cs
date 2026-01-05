using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.BankNameRow>;
using MyRow = AdvanceCRM.Masters.BankNameRow;

namespace AdvanceCRM.Masters
{
    public interface IBankNameRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BankNameRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBankNameRetrieveHandler
    {
        public BankNameRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}