using AdvanceCRM.Administration;
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

            // Include all expression/view fields that the Excel exporter needs
            request.IncludeColumns = new HashSet<string>
            {
                nameof(MisInitialProcessRow.ContactPersonName),
                nameof(MisInitialProcessRow.ContactPersonPhone),
                nameof(MisInitialProcessRow.ContactPersonEmail),
                nameof(MisInitialProcessRow.ContactPersonAddress),
                nameof(MisInitialProcessRow.SourceName),
                nameof(MisInitialProcessRow.ProductProductTypeName),
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

        private static int? GetInt(object val) { if (val == null) return null; int i; return int.TryParse(val.ToString(), out i) ? i : null; }
        private static decimal? GetDecimal(object val) { if (val == null) return null; decimal d; return decimal.TryParse(val.ToString(), out d) ? d : null; }
        private static DateTime? GetDate(object val) { if (val == null) return null; DateTime dt; return DateTime.TryParse(val.ToString(), out dt) ? dt : null; }

        [HttpPost, ServiceAuthorize("MISInitialProcess:Move To LogInProcess")]
        public StandardResponse MoveToLogInProcess(IUnitOfWork uow, SendMailRequest request)
        {
            var response = new StandardResponse();
            var exist = new MisLogInProcessRow();
            var i = MisLogInProcessRow.Fields;
            exist = uow.Connection.TryFirst<MisLogInProcessRow>(q => q
            .SelectTableFields()
            .Select(i.Id)
            .Where(i.Id == request.Id));

            if (exist != null)
            {
                response.Id = exist.Id.Value;
                response.Status = "Already Moved!";
                return response;
            }

            var f = MisInitialProcessRow.Fields;
            var sourceInitialProcess = uow.Connection.TryById<MisInitialProcessRow>(request.Id, q => q
               .SelectTableFields()
               .Select(f.SourceName));  // Include expression field

            var cmp = CompanyDetailsRow.Fields;
            var company = uow.Connection.TryById<CompanyDetailsRow>(1, q => q
                .SelectTableFields()
                .Select(cmp.AllowMovingNonClosedRecords)
                );

            if (company?.AllowMovingNonClosedRecords != true)
            {
                var initialProcessRow = uow.Connection.TryById<MisInitialProcessRow>(request.Id);
                if (initialProcessRow == null)
                    throw new ValidationError("Initial Process record not found");
            }

            int loginProcessId;
            try
            {
                var conn = uow.Connection;
                {
                    String str;
                    if (sourceInitialProcess != null)
                    {
                        str = @"INSERT INTO MISLogInProcess(
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
                            OwnerId, AssignedId, AdditionalInformation, RRSourceId, LeadStageId
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
                            @OwnerId, @AssignedId, @AdditionalInformation, @RRSourceId, @LeadStageId
                        )";
                    }
                    else
                    {
                        throw new ValidationError("Initial Process record not found");
                    }

                    Dapper.SqlMapper.Execute(conn, str, new
                    {
                        SrNo = sourceInitialProcess.SrNo,
                        SourceName = sourceInitialProcess.SourceName,
                        CustomerName = sourceInitialProcess.CustomerName,
                        FirmName = sourceInitialProcess.FirmName,
                        BankSourceOrCompanyName = sourceInitialProcess.BankSourceOrCompanyName,
                        FileHandledBy = sourceInitialProcess.FileHandledBy,
                        ContactPersonInTeam = sourceInitialProcess.ContactPersonInTeam,
                        SalesManager = sourceInitialProcess.SalesManager,
                        Location = sourceInitialProcess.Location,
                        ProductId = sourceInitialProcess.ProductId,
                        Requirement = sourceInitialProcess.Requirement,
                        NatureOfBusinessProfile = sourceInitialProcess.NatureOfBusinessProfile,
                        ProfileOfTheLead = sourceInitialProcess.ProfileOfTheLead,
                        BusinessVintage = sourceInitialProcess.BusinessVintage,
                        BusinessDetailId = sourceInitialProcess.BusinessDetailId,
                        CompanyTypeId = sourceInitialProcess.CompanyTypeId,
                        AccountTypeId = sourceInitialProcess.AccountTypeId,
                        FileReceivedDateTime = sourceInitialProcess.FileReceivedDateTime,
                        QueriesGivenTime = sourceInitialProcess.QueriesGivenTime,
                        FileCompletionDateTime = sourceInitialProcess.FileCompletionDateTime,
                        SystemLoginDate = sourceInitialProcess.SystemLoginDate,
                        UnderwritingDate = sourceInitialProcess.UnderwritingDate,
                        DisbursementDate = sourceInitialProcess.DisbursementDate,
                        Year = sourceInitialProcess.Year,
                        MonthId = sourceInitialProcess.MonthId,
                        BankNameId = sourceInitialProcess.BankNameId,
                        LoanAccountNumber = sourceInitialProcess.LoanAccountNumber,
                        PrimeEmergingId = sourceInitialProcess.PrimeEmergingId,
                        MISDirectIndirectId = sourceInitialProcess.MisDirectIndirectId,
                        InhouseBankId = sourceInitialProcess.InhouseBankId,
                        LoanAmount = sourceInitialProcess.LoanAmount,
                        Amount = sourceInitialProcess.Amount,
                        NetAmt = sourceInitialProcess.NetAmt,
                        AdvanceEMI = sourceInitialProcess.AdvanceEmi,
                        TOPreviousYear = sourceInitialProcess.ToPreviousYear,
                        TOLatestYear = sourceInitialProcess.ToLatestYear,
                        ContactNumber = sourceInitialProcess.ContactNumber,
                        CompanyMailId = sourceInitialProcess.CompanyMailId,
                        EmployeeName = sourceInitialProcess.EmployeeName,
                        ConfirmationMailTakenOrNot = sourceInitialProcess.ConfirmationMailTakenOrNot,
                        AgreementSigningPersonName = sourceInitialProcess.AgreementSigningPersonName,
                        LogInLoanStatusId = sourceInitialProcess.LogInLoanStatusId,
                        SalesLoanStatusId = sourceInitialProcess.SalesLoanStatusId,
                        MISDisbursementStatusId = sourceInitialProcess.MisDisbursementStatusId,
                        Remark = sourceInitialProcess.Remark,
                        StageOfTheCase = sourceInitialProcess.StageOfTheCase,
                        SubInsurancePF = sourceInitialProcess.SubInsurancePf,
                        OwnerId = sourceInitialProcess.OwnerId,
                        AssignedId = sourceInitialProcess.AssignedId,
                        AdditionalInformation = sourceInitialProcess.AdditionalInformation,
                        RRSourceId = sourceInitialProcess.RRSourceId,
                        LeadStageId = sourceInitialProcess.LeadStageId
                    });

                    var lastRecord = conn.TryFirst<MisLogInProcessRow>(l => l
                    .Select(MisLogInProcessRow.Fields.Id)
                    .OrderBy(MisLogInProcessRow.Fields.Id, desc: true)
                    );
                    loginProcessId = lastRecord.Id.Value;
                }
                response.Id = loginProcessId;
                response.Status = "Initial Process moved to Login Process successfully";
            }
            catch (Exception ex)
            {
                response.Id = -1;
                response.Status = ex.Message.ToString();
            }
            return response;
        }
    }
}