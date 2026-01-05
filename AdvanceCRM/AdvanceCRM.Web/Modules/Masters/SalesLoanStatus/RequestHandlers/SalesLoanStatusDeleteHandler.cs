using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.SalesLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ISalesLoanStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesLoanStatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISalesLoanStatusDeleteHandler
    {
        public SalesLoanStatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}