using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.MonthsInYearRow>;
using MyRow = AdvanceCRM.Masters.MonthsInYearRow;

namespace AdvanceCRM.Masters
{
    public interface IMonthsInYearRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthsInYearRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMonthsInYearRetrieveHandler
    {
        public MonthsInYearRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}