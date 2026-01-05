using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales
{
    public interface IInsideSalesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class InsideSalesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInsideSalesDeleteHandler
    {
        public InsideSalesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}