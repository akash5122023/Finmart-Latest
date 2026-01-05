using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.MonthsInYearRow>;
using MyRow = AdvanceCRM.Masters.MonthsInYearRow;

namespace AdvanceCRM.Masters
{
    public interface IMonthsInYearListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthsInYearListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMonthsInYearListHandler
    {
        public MonthsInYearListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}