using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.MonthsInYearRow;

namespace AdvanceCRM.Masters
{
    public interface IMonthsInYearDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MonthsInYearDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMonthsInYearDeleteHandler
    {
        public MonthsInYearDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}