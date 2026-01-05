using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.LogInLoanStatusRow;

namespace AdvanceCRM.Masters
{
    public interface ILogInLoanStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class LogInLoanStatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILogInLoanStatusDeleteHandler
    {
        public LogInLoanStatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}