using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.CustomerApprovalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.CustomerApprovalRow;

namespace AdvanceCRM.Masters
{
    public interface ICustomerApprovalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class CustomerApprovalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICustomerApprovalSaveHandler
    {
        public CustomerApprovalSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}