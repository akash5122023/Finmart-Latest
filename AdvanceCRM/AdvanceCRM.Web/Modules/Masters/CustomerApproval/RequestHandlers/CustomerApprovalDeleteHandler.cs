using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.CustomerApprovalRow;

namespace AdvanceCRM.Masters
{
    public interface ICustomerApprovalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerApprovalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerApprovalDeleteHandler
    {
        public CustomerApprovalDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}