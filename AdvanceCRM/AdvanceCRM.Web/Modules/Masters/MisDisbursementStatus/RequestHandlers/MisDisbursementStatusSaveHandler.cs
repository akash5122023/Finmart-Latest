using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.MisDisbursementStatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.MisDisbursementStatusRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDisbursementStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementStatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementStatusSaveHandler
    {
        public MisDisbursementStatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}