using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.BankNameRow>;
using MyRow = AdvanceCRM.Masters.BankNameRow;

namespace AdvanceCRM.Masters
{
    public interface IBankNameListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BankNameListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBankNameListHandler
    {
        public BankNameListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}