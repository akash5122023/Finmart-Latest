using AdvanceCRM.Common.Helpers;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Operations.MisLogInProcessRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisLogInProcessSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisLogInProcessSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMisLogInProcessSaveHandler
    {
        public MisLogInProcessSaveHandler(IRequestContext context)
             : base(context)
        {
        }
        protected override void ValidateRequest()
        {
            // 🔥 Excel Import → skip mandatory validation
            if (Request is ExcelImportSaveRequest<MisLogInProcessRow> excelReq
                && excelReq.IsExcelImport)
            {
                return;
            }

            // Normal UI Save → validation applies
            base.ValidateRequest();
        }
    }
}