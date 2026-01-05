using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.InHouseBankRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.InHouseBankRow;

namespace AdvanceCRM.Masters
{
    public interface IInHouseBankSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class InHouseBankSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInHouseBankSaveHandler
    {
        public InHouseBankSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}