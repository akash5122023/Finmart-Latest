using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.FinmartInsideSales.InsideSalesRow>;
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales
{
    public interface IInsideSalesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class InsideSalesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInsideSalesRetrieveHandler
    {
        public InsideSalesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}