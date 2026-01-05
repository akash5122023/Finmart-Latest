using AdvanceCRM.Common.Helpers;
using AdvanceCRM.FinmartInsideSales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using static MVC.Views.Operations;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations.Endpoints
{
    [Route("Services/Operations/MisLogInProcess/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class MisLogInProcessController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IMisLogInProcessSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IMisLogInProcessSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IMisLogInProcessDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IMisLogInProcessRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IMisLogInProcessListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, IgnoreAntiforgeryToken, AuthorizeList(typeof(MisLogInProcessRow))]
        public FileContentResult ListExcel(
         IDbConnection connection,
         [FromForm] ListRequest request, // Bind from form POSTs
         [FromForm] string Ids,
         [FromServices] MisLogInProcessListHandler handler)
        {
            request ??= new ListRequest { Take = 0 }; // Defensive: always have a request

            request.IncludeColumns = new HashSet<string>
            {
                nameof(MisLogInProcessRow.MonthMonthsName),
                nameof(MisLogInProcessRow.BankNameBankNames),
                //nameof(MisLogInProcessRow.CompanyTypeCompanyTypeName),
                nameof(MisLogInProcessRow.ProductProductTypeName),
                nameof(MisLogInProcessRow.PrimeEmergingPrimeEmergingName),
                nameof(MisLogInProcessRow.InhouseBankInHouseBankType),
                nameof(MisLogInProcessRow.LogInLoanStatusLogInLoanStatusName),
                //nameof(MisLogInProcessRow.AccountTypeAccountTypeName),
                //nameof(MisLogInProcessRow.SalesLoanStatusSalesLoanStatusName),
                //nameof(MisLogInProcessRow.StageOfTheCaseCasesStageName),
                nameof(MisLogInProcessRow.OwnerUsername),
                nameof(MisLogInProcessRow.AssignedUsername)
             };

            var data = List(connection, request, handler).Entities.ToList();
            if (!string.IsNullOrWhiteSpace(Ids))
            {
                var idList = Ids.Split(',').Select(x =>
                {
                    int v; return int.TryParse(x.Trim(), out v) ? (int?)v : null;
                }).Where(x => x.HasValue).Select(x => x!.Value).ToHashSet();
                if (idList.Count > 0)
                    data = data.Where(x => x.Id.HasValue && idList.Contains(x.Id.Value)).ToList();
            }
            var bytes = AdvanceCRM.Web.Modules.Common.AppServices.MISLogInProcessExcelExporter.ExportToExcel(data);
            var fileName = "MISLogInProcessList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss", System.Globalization.CultureInfo.InvariantCulture) + ".xlsx";
            return Serenity.Web.ExcelContentResult.Create(bytes, fileName);
        }
        [HttpPost, IgnoreAntiforgeryToken]
        public IActionResult ImportExcel([FromServices] IUnitOfWork uow, IFormFile file, [FromServices] MisLogInProcessSaveHandler saveHandler)
        {
            try
            {
                if (file == null || !file.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    return Content("Please upload a valid .xlsx file.", "text/plain");
                int imported = 0, skipped = 0, failed = 0;
                var errors = new List<string>();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(file.OpenReadStream()))
                {
                    var ws = package.Workbook.Worksheets[0];
                    int rowCount = ws.Dimension.End.Row;
                    for (int row = 2; row <= rowCount; row++)
                    {
                        try
                        {
                            var misloginprocess = new MisLogInProcessRow
                            {
                                Year = ws.Cells[row, 2].Text,
                                MonthMonthsName = ws.Cells[row, 3].Text,
                                FileReceivedDateTime = GetDate(ws.Cells[row, 4].Text),                                
                                SourceName = ws.Cells[row, 5].Text,
                                BankSourceOrCompanyName = ws.Cells[row, 6].Text,                                
                                BankNameId = LookupId(uow.Connection, "BankName", "BankNames", ws.Cells[row, 7].Text),
                                ProductId = LookupId(uow.Connection, "TypesofProducts", "ProductTypeName", ws.Cells[row, 8].Text),
                                CustomerName = ws.Cells[row, 9].Text,
                                FirmName = ws.Cells[row, 10].Text,
                                ContactNumber = ws.Cells[row, 11].Text,
                                PrimeEmergingId = LookupId(uow.Connection, "PrimeEmerging", "PrimeEmergingName", ws.Cells[row, 12].Text),
                                Location = ws.Cells[row, 13].Text,
                                InhouseBankId = LookupId(uow.Connection, "InHouseBank", "InHouseBankType", ws.Cells[row, 14].Text),
                                LogInLoanStatusId = LookupId(uow.Connection, "LogInLoanStatus", "LogInLoanStatusName", ws.Cells[row, 15].Text),
                                Remark = ws.Cells[row, 16].Text,
                                AdditionalInformation = ws.Cells[row, 17].Text,
                                SystemLoginDate = GetDate(ws.Cells[row, 18].Text),
                                UnderwritingDate = GetDate(ws.Cells[row, 19].Text),
                                SalesManager = ws.Cells[row, 20].Text,
                                NatureOfBusinessProfile = ws.Cells[row, 21].Text,
                                ToPreviousYear = GetDecimal(ws.Cells[row, 22].Text),
                                ToLatestYear = GetDecimal(ws.Cells[row, 23].Text),
                                DisbursementDate = GetDate(ws.Cells[row, 24].Text),
                                LoanAccountNumber = ws.Cells[row, 25].Text,
                                OwnerUsername = ws.Cells[row, 26].Text, 
                                AssignedUsername = ws.Cells[row, 27].Text

                            };
                            if (misloginprocess.Id.HasValue && misloginprocess.Id.Value > 0)
                            {
                                skipped++; continue;
                            }
                            saveHandler.Create(uow, new ExcelImportSaveRequest<MisLogInProcessRow>
                            {
                                IsExcelImport = true,   // 🔥 THIS disables mandatory validation
                                Entity = misloginprocess
                            });
                            imported++;

                        }
                        catch (Exception ex)
                        {
                            failed++; errors.Add($"Row {row}: {ex.Message}");
                        }
                    }
                }
                if (imported == 0 && failed > 0)
                    return Content("All rows failed to import.\n" + string.Join("\n", errors), "text/plain");
                return Content($"Added: {imported}, Skipped (existing IDs): {skipped}, Failed: {failed}\n" + (errors.Count > 0 ? string.Join("\n", errors) : ""), "text/plain");
            }
            catch (Exception ex)
            {
                return Content("Import failed: " + ex.Message + "\n" + ex.StackTrace, "text/plain");
            }
        }
        private int? LookupId(IDbConnection connection, string tableName, string textColumn, string textValue)
        {
            if (string.IsNullOrWhiteSpace(textValue))
                return null;

            var sql = $"SELECT Id FROM {tableName} WHERE {textColumn} = @textValue";
            return connection.Query<int?>(sql, new { textValue }).FirstOrDefault();
        }
        private static int? GetInt(object val) { if (val == null) return null; int i; return int.TryParse(val.ToString(), out i) ? i : null; }
        private static decimal? GetDecimal(object val) { if (val == null) return null; decimal d; return decimal.TryParse(val.ToString(), out d) ? d : null; }
        private static DateTime? GetDate(object val) { if (val == null) return null; DateTime dt; return DateTime.TryParse(val.ToString(), out dt) ? dt : null; }

    }
}