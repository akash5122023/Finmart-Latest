using AdvanceCRM.Common.Helpers;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Operations.MisDisbursementProcessRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Operations.MisDisbursementProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisDisbursementProcessSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementProcessSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementProcessSaveHandler
    {
        public MisDisbursementProcessSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ValidateRequest()
        {
            // 🔥 Excel Import → skip mandatory validation
            if (Request is ExcelImportSaveRequest<MisDisbursementProcessRow> excelReq
                && excelReq.IsExcelImport)
            {
                return;
            }

            // Normal UI Save → validation applies
            base.ValidateRequest();
        }
    }
}