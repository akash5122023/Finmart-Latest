using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.SalesLoanStatusRow>;
using MyRow = AdvanceCRM.Masters.SalesLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ISalesLoanStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesLoanStatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesLoanStatusRetrieveHandler
    {
        public SalesLoanStatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}