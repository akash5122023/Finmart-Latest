using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.BusinessDetailsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.BusinessDetailsRow;

namespace AdvanceCRM.Masters
{
    public interface IBusinessDetailsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessDetailsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessDetailsSaveHandler
    {
        public BusinessDetailsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}