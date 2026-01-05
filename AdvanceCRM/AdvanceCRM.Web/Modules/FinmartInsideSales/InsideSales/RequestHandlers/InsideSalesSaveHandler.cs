using AdvanceCRM.Common.Helpers;
using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.FinmartInsideSales.InsideSalesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales
{
    public interface IInsideSalesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class InsideSalesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInsideSalesSaveHandler
    {
        public InsideSalesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ValidateRequest()
        {
            // 🔥 Excel Import → skip mandatory validation
            if (Request is ExcelImportSaveRequest<InsideSalesRow> excelReq
                && excelReq.IsExcelImport)
            {
                return;
            }

            // Normal UI Save → validation applies
            base.ValidateRequest();
        }
    }
}