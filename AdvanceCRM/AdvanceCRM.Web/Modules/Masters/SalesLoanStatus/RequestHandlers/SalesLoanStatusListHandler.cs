using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.SalesLoanStatusRow>;
using MyRow = AdvanceCRM.Masters.SalesLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ISalesLoanStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesLoanStatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISalesLoanStatusListHandler
    {
        public SalesLoanStatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}