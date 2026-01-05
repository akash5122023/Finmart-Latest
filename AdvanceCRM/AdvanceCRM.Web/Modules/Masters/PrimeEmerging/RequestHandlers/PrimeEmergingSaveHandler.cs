using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.PrimeEmergingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.PrimeEmergingRow;

namespace AdvanceCRM.Masters
{
    public interface IPrimeEmergingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PrimeEmergingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPrimeEmergingSaveHandler
    {
        public PrimeEmergingSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}