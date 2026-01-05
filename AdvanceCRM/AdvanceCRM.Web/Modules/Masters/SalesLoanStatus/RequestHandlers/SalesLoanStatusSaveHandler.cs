using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.SalesLoanStatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.SalesLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ISalesLoanStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class SalesLoanStatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISalesLoanStatusSaveHandler
    {
        public SalesLoanStatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}