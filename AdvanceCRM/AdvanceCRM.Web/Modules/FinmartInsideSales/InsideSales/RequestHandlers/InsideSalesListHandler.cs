using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.FinmartInsideSales.InsideSalesRow>;
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales
{
    public interface IInsideSalesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class InsideSalesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInsideSalesListHandler
    {
        public InsideSalesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}