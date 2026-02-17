using AdvanceCRM.Administration;
using AdvanceCRM.Common.Helpers;
using AdvanceCRM.FinmartInsideSales;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
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

        protected override void BeforeSave()
        {
            base.BeforeSave();

            // Auto-set OwnerId and AssignedId to current user on create
            if (IsCreate)
            {
                var user = (UserDefinition)Context.User.ToUserDefinition();
                if (user != null)
                {
                    // Set OwnerId (creator) to current user if not already set
                    if (Row.OwnerId == null || Row.OwnerId == 0)
                    {
                        Row.OwnerId = user.UserId;
                    }

                    // Set AssignedId to current user if not already set
                    if (Row.AssignedId == null || Row.AssignedId == 0)
                    {
                        Row.AssignedId = user.UserId;
                    }
                }
            }
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