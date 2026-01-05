using AdvanceCRM.Administration;
using AdvanceCRM.Common.Helpers;
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
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales.Endpoints
{
    [Route("Services/FinmartInsideSales/InsideSales/[action]")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class InsideSalesController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IInsideSalesSaveHandler handler)
        {
            return handler.Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
            [FromServices] IInsideSalesSaveHandler handler)
        {
            return handler.Update(uow, request);
        }

        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
            [FromServices] IInsideSalesDeleteHandler handler)
        {
            return handler.Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
            [FromServices] IInsideSalesRetrieveHandler handler)
        {
            return handler.Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
            [FromServices] IInsideSalesListHandler handler)
        {
            return handler.List(connection, request);
        }

        [HttpPost, IgnoreAntiforgeryToken, AuthorizeList(typeof(InsideSalesRow))]
        public FileContentResult ListExcel(
         IDbConnection connection,
         [FromForm] ListRequest request, // Bind from form POSTs
         [FromForm] string Ids,
         [FromServices] InsideSalesListHandler handler)
        {
            request ??= new ListRequest { Take = 0 }; // Defensive: always have a request

            request.IncludeColumns = new HashSet<string>
            {
                nameof(InsideSalesRow.MonthMonthsName),
                nameof(InsideSalesRow.CompanyTypeCompanyTypeName),
                nameof(InsideSalesRow.ProductProductTypeName),
                nameof(InsideSalesRow.BusinessDetailBusinessDetailType),
                nameof(InsideSalesRow.AccountTypeAccountTypeName),
                nameof(InsideSalesRow.SalesLoanStatusSalesLoanStatusName),
                nameof(InsideSalesRow.StageOfTheCaseCasesStageName),
                nameof(InsideSalesRow.OwnerUsername),
                nameof(InsideSalesRow.AssignedUsername)
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
            var bytes = AdvanceCRM.Web.Modules.Common.AppServices.InsideSalesExcelExporter.ExportToExcel(data);
            var fileName = "InsideSalesList_" + DateTime.Now.ToString("yyyyMMdd_HHmmss", System.Globalization.CultureInfo.InvariantCulture) + ".xlsx";
            return Serenity.Web.ExcelContentResult.Create(bytes, fileName);
        }
        [HttpPost, IgnoreAntiforgeryToken]
        public IActionResult ImportExcel([FromServices] IUnitOfWork uow, IFormFile file, [FromServices] InsideSalesSaveHandler saveHandler)
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
                            var insidesales = new InsideSalesRow
                            {
                                MonthMonthsName = ws.Cells[row, 2].Text,
                                FileReceivedDateTime = GetDate(ws.Cells[row, 3].Text),
                                BankSourceOrCompanyName = ws.Cells[row, 4].Text,

                                // Lookup IDs for dropdowns
                                CompanyTypeId = LookupId(uow.Connection, "TypesOfCompanies", "CompanyTypeName", ws.Cells[row, 5].Text),
                                ProductId = LookupId(uow.Connection, "TypesofProducts", "ProductTypeName", ws.Cells[row, 9].Text),
                                BusinessDetailId = LookupId(uow.Connection, "BusinessDetailType", "BusinessDetailTypeName", ws.Cells[row, 12].Text),
                                AccountTypeId = LookupId(uow.Connection, "AccountType", "AccountTypeName", ws.Cells[row, 13].Text),
                                SalesLoanStatusId = LookupId(uow.Connection, "SalesLoanStatus", "SalesLoanStatusName", ws.Cells[row, 14].Text),
                                StageOfTheCaseId = LookupId(uow.Connection, "StageOfTheCase", "CasesStageName", ws.Cells[row, 18].Text),

                                ProfileOfTheLead = ws.Cells[row, 6].Text,
                                ContactNumber = ws.Cells[row, 7].Text,
                                CompanyMailId = ws.Cells[row, 8].Text,
                                NatureOfBusinessProfile = ws.Cells[row, 10].Text,
                                BusinessVintage = ws.Cells[row, 11].Text,
                                LoanAmount = GetDecimal(ws.Cells[row, 15].Text),
                                Remark = ws.Cells[row, 16].Text,
                                AdditionalInformation = ws.Cells[row, 17].Text,

                                OwnerUsername = ws.Cells[row, 19].Text, //
                                AssignedUsername = ws.Cells[row, 20].Text

                            };
                            if (insidesales.Id.HasValue && insidesales.Id.Value > 0)
                            {
                                skipped++; continue;
                            }
                            saveHandler.Create(uow, new ExcelImportSaveRequest<InsideSalesRow>
                            {
                                IsExcelImport = true,   // 🔥 THIS disables mandatory validation
                                Entity = insidesales
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

        //private int? LookupUserId(IDbConnection connection, string username)
        //{
        //    if (string.IsNullOrWhiteSpace(username))
        //        return null;

        //    var user = connection.TryFirst<UserRow>(q =>
        //    {
        //        q.Select(f => f.UserId)       // Select the ID
        //         .Where(f => f.Username == username); // Filter by username
        //    });

        //    return user?.UserId;
        //}


        private static int? GetInt(object val) { if (val == null) return null; int i; return int.TryParse(val.ToString(), out i) ? i : null; }
        private static decimal? GetDecimal(object val) { if (val == null) return null; decimal d; return decimal.TryParse(val.ToString(), out d) ? d : null; }
        private static DateTime? GetDate(object val) { if (val == null) return null; DateTime dt; return DateTime.TryParse(val.ToString(), out dt) ? dt : null; }

    }
}