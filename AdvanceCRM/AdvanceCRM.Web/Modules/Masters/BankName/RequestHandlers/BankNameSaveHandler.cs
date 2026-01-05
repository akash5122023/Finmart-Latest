using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.BankNameRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.BankNameRow;

namespace AdvanceCRM.Masters
{
    public interface IBankNameSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BankNameSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBankNameSaveHandler
    {
        public BankNameSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}