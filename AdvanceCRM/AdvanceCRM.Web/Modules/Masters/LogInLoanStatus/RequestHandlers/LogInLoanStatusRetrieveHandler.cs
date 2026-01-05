using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.LogInLoanStatusRow>;
using MyRow = AdvanceCRM.Masters.LogInLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ILogInLoanStatusRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class LogInLoanStatusRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILogInLoanStatusRetrieveHandler
    {
        public LogInLoanStatusRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}