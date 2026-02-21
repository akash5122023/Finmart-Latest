using AdvanceCRM.Administration;
using AdvanceCRM.Common.Helpers;
using AdvanceCRM.Contacts;
using AdvanceCRM.FinmartInsideSales;
using AdvanceCRM.Operations;
using AdvanceCRM.Sales;
using AdvanceCRM.Template;
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
        private readonly ISqlConnections sqlConnections;

        public InsideSalesController(ISqlConnections sqlConnections)
        {
            this.sqlConnections = sqlConnections;
        }
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
                                // Lookup Month ID from month name
                                MonthId = LookupId(uow.Connection, "MonthsInYear", "MonthsName", ws.Cells[row, 2].Text),
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

                                // Lookup User IDs from usernames
                                OwnerId = LookupUserId(uow.Connection, ws.Cells[row, 19].Text),
                                AssignedId = LookupUserId(uow.Connection, ws.Cells[row, 20].Text)

                            };

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

            // Whitelist validation to prevent SQL injection
            var allowedTables = new Dictionary<string, string>
            {
                { "TypesOfCompanies", "CompanyTypeName" },
                { "TypesofProducts", "ProductTypeName" },
                { "BusinessDetailType", "BusinessDetailTypeName" },
                { "AccountType", "AccountTypeName" },
                { "SalesLoanStatus", "SalesLoanStatusName" },
                { "StageOfTheCase", "CasesStageName" },
                { "MonthsInYear", "MonthsName" }
            };

            if (!allowedTables.TryGetValue(tableName, out var validColumn) || validColumn != textColumn)
                throw new ArgumentException($"Invalid table or column: {tableName}.{textColumn}");

            var sql = $"SELECT Id FROM [{tableName}] WHERE [{textColumn}] = @textValue";
            return connection.Query<int?>(sql, new { textValue }).FirstOrDefault();
        }

        private int? LookupUserId(IDbConnection connection, string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            var sql = "SELECT UserId FROM [Users] WHERE [Username] = @username";
            return connection.Query<int?>(sql, new { username }).FirstOrDefault();
        }

        [HttpPost, ServiceAuthorize(PermissionKeys.Update)]
        public StandardResponse MoveToInitialProcess(IUnitOfWork uow, SendMailRequest request)
        {
            var response = new StandardResponse();
            var exist = new MisInitialProcessRow();
            var i = MisInitialProcessRow.Fields;
            exist = uow.Connection.TryFirst<MisInitialProcessRow>(q => q
            .SelectTableFields()
            .Select(i.Id)
            .Where(i.Id == request.Id));

            if (exist != null)
            {
                response.Id = exist.Id.Value;
                response.Status = "Already Moved!";
                return response;
            }

            var data = new InsideSalesData();

            var quot = InsideSalesRow.Fields;
            var sourceInsideSales = uow.Connection.TryById<InsideSalesRow>(request.Id, q => q
               .SelectTableFields());
            var cmp = CompanyDetailsRow.Fields;
            data.Company = uow.Connection.TryById<CompanyDetailsRow>(1, q => q
                .SelectTableFields()
                .Select(cmp.AllowMovingNonClosedRecords)
                );
            if (data.Company.AllowMovingNonClosedRecords != true)
            {
                // ALWAYS load the row from DB
                var insideSalesRow = uow.Connection.TryById<InsideSalesRow>(request.Id);

                if (insideSalesRow == null)
                    throw new ValidationError("Inside Sales not found");
            }
            //int contactsid;
            int insalid;
            try
            {
                var conn = uow.Connection;
                {
                    String str;
                    if (sourceInsideSales != null)
                    {
                        str = @"INSERT INTO MISInitialProcess(
                            SrNo, SourceName, CustomerName, FirmName, BankSourceOrCompanyName, 
                            FileHandledBy, ContactPersonInTeam, SalesManager, Location, ProductId, 
                            Requirement, NatureOfBusinessProfile, ProfileOfTheLead, BusinessVintage, 
                            BusinessDetailId, CompanyTypeId, AccountTypeId, FileReceivedDateTime, 
                            QueriesGivenTime, FileCompletionDateTime, SystemLoginDate, UnderwritingDate, 
                            DisbursementDate, Year, MonthId, BankNameId, LoanAccountNumber, 
                            PrimeEmergingId, MISDirectIndirectId, InhouseBankId, LoanAmount, 
                            Amount, NetAmt, AdvanceEMI, TOPreviousYear, TOLatestYear, 
                            ContactNumber, CompanyMailId, EmployeeName, ConfirmationMailTakenOrNot, 
                            AgreementSigningPersonName, LogInLoanStatusId, SalesLoanStatusId, 
                            MISDisbursementStatusId, Remark, StageOfTheCase, SubInsurancePF, 
                            OwnerId, AssignedId, AdditionalInformation
                        ) VALUES (
                            @SrNo, @SourceName, @CustomerName, @FirmName, @BankSourceOrCompanyName, 
                            @FileHandledBy, @ContactPersonInTeam, @SalesManager, @Location, @ProductId, 
                            @Requirement, @NatureOfBusinessProfile, @ProfileOfTheLead, @BusinessVintage, 
                            @BusinessDetailId, @CompanyTypeId, @AccountTypeId, @FileReceivedDateTime, 
                            @QueriesGivenTime, @FileCompletionDateTime, @SystemLoginDate, @UnderwritingDate, 
                            @DisbursementDate, @Year, @MonthId, @BankNameId, @LoanAccountNumber, 
                            @PrimeEmergingId, @MISDirectIndirectId, @InhouseBankId, @LoanAmount, 
                            @Amount, @NetAmt, @AdvanceEMI, @TOPreviousYear, @TOLatestYear, 
                            @ContactNumber, @CompanyMailId, @EmployeeName, @ConfirmationMailTakenOrNot, 
                            @AgreementSigningPersonName, @LogInLoanStatusId, @SalesLoanStatusId, 
                            @MISDisbursementStatusId, @Remark, @StageOfTheCase, @SubInsurancePF, 
                            @OwnerId, @AssignedId, @AdditionalInformation
                        )";
                    }
                    else
                    {
                        throw new ValidationError("Inside Sales record not found");
                    }

                    Dapper.SqlMapper.Execute(conn, str, new
                    {
                        SrNo = sourceInsideSales.SrNo,
                        SourceName = sourceInsideSales.SourceName,
                        CustomerName = sourceInsideSales.CustomerName,
                        FirmName = sourceInsideSales.FirmName,
                        BankSourceOrCompanyName = sourceInsideSales.BankSourceOrCompanyName,
                        FileHandledBy = sourceInsideSales.FileHandledBy,
                        ContactPersonInTeam = sourceInsideSales.ContactPersonInTeam,
                        SalesManager = sourceInsideSales.SalesManager,
                        Location = sourceInsideSales.Location,
                        ProductId = sourceInsideSales.ProductId,
                        Requirement = sourceInsideSales.Requirement,
                        NatureOfBusinessProfile = sourceInsideSales.NatureOfBusinessProfile,
                        ProfileOfTheLead = sourceInsideSales.ProfileOfTheLead,
                        BusinessVintage = sourceInsideSales.BusinessVintage,
                        BusinessDetailId = sourceInsideSales.BusinessDetailId,
                        CompanyTypeId = sourceInsideSales.CompanyTypeId,
                        AccountTypeId = sourceInsideSales.AccountTypeId,
                        FileReceivedDateTime = sourceInsideSales.FileReceivedDateTime,
                        QueriesGivenTime = sourceInsideSales.QueriesGivenTime,
                        FileCompletionDateTime = sourceInsideSales.FileCompletionDateTime,
                        SystemLoginDate = sourceInsideSales.SystemLoginDate,
                        UnderwritingDate = sourceInsideSales.UnderwritingDate,
                        DisbursementDate = sourceInsideSales.DisbursementDate,
                        Year = sourceInsideSales.Year,
                        MonthId = sourceInsideSales.MonthId,
                        BankNameId = sourceInsideSales.BankNameId,
                        LoanAccountNumber = sourceInsideSales.LoanAccountNumber,
                        PrimeEmergingId = sourceInsideSales.PrimeEmergingId,
                        MISDirectIndirectId = sourceInsideSales.MisDirectIndirectId,
                        InhouseBankId = sourceInsideSales.InhouseBankId,
                        LoanAmount = sourceInsideSales.LoanAmount,
                        Amount = sourceInsideSales.Amount,
                        NetAmt = sourceInsideSales.NetAmt,
                        AdvanceEMI = sourceInsideSales.AdvanceEmi,
                        TOPreviousYear = sourceInsideSales.ToPreviousYear,
                        TOLatestYear = sourceInsideSales.ToLatestYear,
                        ContactNumber = sourceInsideSales.ContactNumber,
                        CompanyMailId = sourceInsideSales.CompanyMailId,
                        EmployeeName = sourceInsideSales.EmployeeName,
                        ConfirmationMailTakenOrNot = sourceInsideSales.ConfirmationMailTakenOrNot,
                        AgreementSigningPersonName = sourceInsideSales.AgreementSigningPersonName,
                        LogInLoanStatusId = sourceInsideSales.LogInLoanStatusId,
                        SalesLoanStatusId = sourceInsideSales.SalesLoanStatusId,
                        MISDisbursementStatusId = sourceInsideSales.MisDisbursementStatusId,
                        Remark = sourceInsideSales.Remark,
                        StageOfTheCase = sourceInsideSales.StageOfTheCaseId.HasValue ? sourceInsideSales.StageOfTheCaseId.ToString() : null,
                        SubInsurancePF = sourceInsideSales.SubInsurancePf,
                        OwnerId = sourceInsideSales.OwnerId,
                        AssignedId = sourceInsideSales.AssignedId,
                        AdditionalInformation = sourceInsideSales.AdditionalInformation
                    });
                    var inv = InsideSalesRow.Fields;
                    data.LastInvSO = conn.TryFirst<MisInitialProcessRow>(l => l
                    .Select(MisInitialProcessRow.Fields.Id)
                    .OrderBy(MisInitialProcessRow.Fields.Id, desc: true)
                    );
                    insalid = data.LastInvSO.Id.Value;
                }
                response.Id = insalid;
                response.Status = "Inside Sales moved to Initial Process successfully";
            }
            catch (Exception ex)
            {
                response.Id = -1;
                response.Status = ex.Message.ToString();
            }
            return response;
        }
        private static int? GetInt(object val) { if (val == null) return null; int i; return int.TryParse(val.ToString(), out i) ? i : null; }
        private static decimal? GetDecimal(object val) { if (val == null) return null; decimal d; return decimal.TryParse(val.ToString(), out d) ? d : null; }
        private static DateTime? GetDate(object val) { if (val == null) return null; DateTime dt; return DateTime.TryParse(val.ToString(), out dt) ? dt : null; }

        public class InsideSalesData
        {
            public ContactsRow Contact { get; set; }
            public UserRow User { get; set; }
            public MyRow InsideSales { get; set; }
            public InsideSalesRow LastInv { get; set; }
            public MisInitialProcessRow MisInitialProcess { get; set; }
            public MisInitialProcessRow LastInvSO { get; set; }
            public InvoiceRow LastIn { get; set; }
            //public List<ProductionPlanProductsRow> SalesProducts { get; set; }
            //public List<ProductionPlanProductsRow> IndentProducts { get; set; }
            public CompanyDetailsRow Company { get; set; }
            public InvoiceTemplateRow Template { get; set; }
        }
    }
}
