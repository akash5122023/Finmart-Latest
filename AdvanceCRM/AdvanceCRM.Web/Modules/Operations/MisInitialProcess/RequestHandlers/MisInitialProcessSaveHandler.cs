using AdvanceCRM.Common.Helpers;
using AdvanceCRM.FinmartInsideSales;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Operations.MisInitialProcessRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessSaveHandler
    {
        public MisInitialProcessSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ValidateRequest()
        {
            // 🔥 Excel Import → skip mandatory validation
            if (Request is ExcelImportSaveRequest<MisInitialProcessRow> excelReq
                && excelReq.IsExcelImport)
            {
                return;
            }

            // Normal UI Save → validation applies
            base.ValidateRequest();
        }
    }
}