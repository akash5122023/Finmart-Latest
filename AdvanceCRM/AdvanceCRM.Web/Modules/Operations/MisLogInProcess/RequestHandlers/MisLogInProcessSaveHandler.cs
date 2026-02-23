using AdvanceCRM.Administration;
using AdvanceCRM.Common.Helpers;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;
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

        protected override void BeforeSave()
        {
            base.BeforeSave();

            // Get current user - try multiple methods to ensure we get the user
            int? currentUserId = null;

            // Method 1: Try from Context.User claims
            var userDef = Context.User?.ToUserDefinition();
            if (userDef != null && userDef.UserId > 0)
            {
                currentUserId = userDef.UserId;
            }

            // Method 2: Fallback to Authorization.UserDefinition
            if (!currentUserId.HasValue || currentUserId == 0)
            {
                var authUser = Authorization.UserDefinition as UserDefinition;
                if (authUser != null && authUser.UserId > 0)
                {
                    currentUserId = authUser.UserId;
                }
            }

            // Auto-set OwnerId and AssignedId to current user on create
            if (IsCreate && currentUserId.HasValue && currentUserId > 0)
            {
                // Set OwnerId (creator) to current user if not already set
                if (!Row.OwnerId.HasValue || Row.OwnerId == 0)
                {
                    Row.OwnerId = currentUserId;
                }

                // Set AssignedId to current user if not already set
                if (!Row.AssignedId.HasValue || Row.AssignedId == 0)
                {
                    Row.AssignedId = currentUserId;
                }
            }
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