using AdvanceCRM.Administration;
using AdvanceCRM.Common.Helpers;
using Serenity.Services;
using Serenity.Web;
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