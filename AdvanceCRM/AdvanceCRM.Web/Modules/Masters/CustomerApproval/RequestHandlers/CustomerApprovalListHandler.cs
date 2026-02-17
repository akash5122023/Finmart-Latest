using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.CustomerApprovalRow>;
using MyRow = AdvanceCRM.Masters.CustomerApprovalRow;

namespace AdvanceCRM.Masters
{
    public interface ICustomerApprovalListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerApprovalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerApprovalListHandler
    {
        public CustomerApprovalListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}