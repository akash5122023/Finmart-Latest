using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.LogInLoanStatusRow>;
using MyRow = AdvanceCRM.Masters.LogInLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ILogInLoanStatusListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class LogInLoanStatusListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILogInLoanStatusListHandler
    {
        public LogInLoanStatusListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}