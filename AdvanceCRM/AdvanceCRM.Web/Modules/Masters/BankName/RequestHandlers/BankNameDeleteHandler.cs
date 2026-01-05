using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.BankNameRow;

namespace AdvanceCRM.Masters
{
    public interface IBankNameDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BankNameDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBankNameDeleteHandler
    {
        public BankNameDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}