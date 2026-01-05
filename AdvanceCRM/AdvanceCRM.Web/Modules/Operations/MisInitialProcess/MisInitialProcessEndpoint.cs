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
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations.Endpoints
{
    [Route("Services/Operations/MisInitialProcess/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class MisInitialProcessController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IMisInitialProcessSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IMisInitialProcessSaveHandler handler)
        {
            return handler.Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IMisInitialProcessDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IMisInitialProcessRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IMisInitialProcessListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, IgnoreAntiforgeryToken, AuthorizeList(typeof(MisInitialProcessRow))]
        public FileContentResult ListExcel(
         IDbConnection connection,
         [FromForm] ListRequest request, // Bind from form POSTs
         [FromForm] string Ids,
         [FromServices] MisInitialProcessListHandler handler)
        {
            request ??= new ListRequest { Take = 0 }; // Defensive: always have a request

            request.IncludeColumns = new HashSet<string>
            {
                nameof(MisInitialProcessRow.ContactPersonName),
                nameof(MisInitialProcessRow.ContactPersonPhone),
                nameof(MisInitialProcessRow.ProductProductTypeName),
                nameof(MisInitialProcessRow.ContactPersonEmail),
                nameof(MisInitialProcessRow.ContactPersonEmail),
                //nameof(MisInitialProcessRow.SalesLoanStatusSalesLoanStatusName),
                //nameof(MisInitialProcessRow.StageOfTheCaseCasesStageName),
                nameof(MisInitialProcessRow.OwnerUsername),
                nameof(MisInitialProcessRow.AssignedUsername)
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
            var bytes = AdvanceCRM.Web.Modules.Common.AppServices.MISInitialProcessExcelExporter.ExportToExcel(data);
            var fileName = "MISInitialProcessList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss", System.Globalization.CultureInfo.InvariantCulture) + ".xlsx";
            return Serenity.Web.ExcelContentResult.Create(bytes, fileName);
        }
        [HttpPost, IgnoreAntiforgeryToken]
        public IActionResult ImportExcel([FromServices] IUnitOfWork uow, IFormFile file, [FromServices] MisInitialProcessSaveHandler saveHandler)
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
                            var misinitialprocess = new MisInitialProcessRow
                            {
                                ContactPersonName = ws.Cells[row, 2].Text,
                                ContactPersonPhone = ws.Cells[row, 3].Text,
                                ContactPersonEmail = ws.Cells[row, 4].Text,
                                ContactPersonAddress = ws.Cells[row, 5].Text,
                                SourceName = ws.Cells[row, 6].Text,
                                CustomerName = ws.Cells[row, 7].Text,
                                //MonthMonthsName = ws.Cells[row, 2].Text,
                                //FileReceivedDateTime = GetDate(ws.Cells[row, 3].Text),
                                BankSourceOrCompanyName = ws.Cells[row, 8].Text,

                                // Lookup IDs for dropdowns
                                //CompanyTypeId = LookupId(uow.Connection, "TypesOfCompanies", "CompanyTypeName", ws.Cells[row, 5].Text),
                                ProductId = LookupId(uow.Connection, "TypesofProducts", "ProductTypeName", ws.Cells[row, 9].Text),
                                //BusinessDetailId = LookupId(uow.Connection, "BusinessDetails", "BusinessDetailTypeName", ws.Cells[row, 12].Text),
                                //AccountTypeId = LookupId(uow.Connection, "TypesOfAccounts", "AccountTypeName", ws.Cells[row, 13].Text),
                                //SalesLoanStatusId = LookupId(uow.Connection, "SalesLoanStatus", "SalesLoanStatusName", ws.Cells[row, 14].Text),
                                //StageOfTheCaseId = LookupId(uow.Connection, "StageOfTheCase", "CasesStageName", ws.Cells[row, 18].Text),
                                Requirement = ws.Cells[row, 10].Text,
                                FileReceivedDateTime = GetDate(ws.Cells[row,11].Text),
                                QueriesGivenTime = GetDate(ws.Cells[row, 12].Text),
                                FileCompletionDateTime = GetDate(ws.Cells[row, 13].Text),
                                //ProfileOfTheLead = ws.Cells[row, 6].Text,
                                //ContactNumber = ws.Cells[row, 7].Text,
                                //CompanyMailId = ws.Cells[row, 8].Text,
                                //NatureOfBusinessProfile = ws.Cells[row, 10].Text,
                                //BusinessVintage = ws.Cells[row, 11].Text,
                                //LoanAmount = GetDecimal(ws.Cells[row, 15].Text),
                                //Remark = ws.Cells[row, 16].Text,
                                AdditionalInformation = ws.Cells[row, 14].Text,

                                OwnerUsername = ws.Cells[row, 15].Text, //
                                AssignedUsername = ws.Cells[row, 16].Text

                            };
                            if (misinitialprocess.Id.HasValue && misinitialprocess.Id.Value > 0)
                            {
                                skipped++; continue;
                            }
                            saveHandler.Create(uow, new ExcelImportSaveRequest<MisInitialProcessRow>
                            {
                                IsExcelImport = true,   // 🔥 THIS disables mandatory validation
                                Entity = misinitialprocess
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