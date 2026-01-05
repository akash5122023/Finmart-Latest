using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.MonthsInYearRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.MonthsInYearRow;

namespace AdvanceCRM.Masters
{
    public interface IMonthsInYearSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthsInYearSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMonthsInYearSaveHandler
    {
        public MonthsInYearSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}