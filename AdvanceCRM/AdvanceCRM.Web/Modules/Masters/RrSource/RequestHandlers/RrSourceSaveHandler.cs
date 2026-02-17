using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.RrSourceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.RrSourceRow;

namespace AdvanceCRM.Masters
{
    public interface IRrSourceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class RrSourceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRrSourceSaveHandler
    {
        public RrSourceSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}