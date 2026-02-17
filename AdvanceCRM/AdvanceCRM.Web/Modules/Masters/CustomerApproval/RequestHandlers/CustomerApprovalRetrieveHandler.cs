using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.CustomerApprovalRow>;
using MyRow = AdvanceCRM.Masters.CustomerApprovalRow;

namespace AdvanceCRM.Masters
{
    public interface ICustomerApprovalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerApprovalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerApprovalRetrieveHandler
    {
        public CustomerApprovalRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}