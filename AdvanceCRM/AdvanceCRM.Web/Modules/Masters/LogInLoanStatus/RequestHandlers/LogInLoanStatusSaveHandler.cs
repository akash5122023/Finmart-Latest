using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.LogInLoanStatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.LogInLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ILogInLoanStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class LogInLoanStatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILogInLoanStatusSaveHandler
    {
        public LogInLoanStatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}