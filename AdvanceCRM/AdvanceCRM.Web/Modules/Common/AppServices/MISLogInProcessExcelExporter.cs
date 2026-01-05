
using AdvanceCRM.Operations;
using OfficeOpenXml;
using System.Collections.Generic;

namespace AdvanceCRM.Web.Modules.Common.AppServices
{
    public class MISLogInProcessExcelExporter
    {
        public static byte[] ExportToExcel(List<MisLogInProcessRow> misLogInProcessRows)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("MISLogInProcess");
            // Headers
            string[] headers = new[]
            {
            "Id","Year", "Month Name", "FileReceivedDateTime", "Source Name", "BankSource CompanyName", "Bank Name", "Product Name", "Customer Name", "Firm Name", "ContactNumber", "PrimeEmergingId", "Location", "InhouseBankId", "LogInLoanStatusId", "Remark","Additional Information", "System Login Date", "Underwriting Date", "Sales Manager", "NatureOfBusinessProfile","TO PreviousYear","TO LatestYear","Disbursement Date","LoanAccountNumber","CREATED BY","Assigned To"
        };
            for (int i = 0; i < headers.Length; i++)
                ws.Cells[1, i + 1].Value = headers[i];
            int row = 2;
            foreach (var en in misLogInProcessRows)
            {
                int col = 1;
                ws.Cells[row, col++].Value = en.Id;
                ws.Cells[row, col++].Value = en.Year;
                ws.Cells[row, col++].Value = en.MonthMonthsName;
                ws.Cells[row, col++].Value = en.FileReceivedDateTime?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.SourceName;
                ws.Cells[row, col++].Value = en.BankSourceOrCompanyName;
                ws.Cells[row, col++].Value = en.BankNameBankNames;
                ws.Cells[row, col++].Value = en.ProductProductTypeName;
                ws.Cells[row, col++].Value = en.CustomerName;
                ws.Cells[row, col++].Value = en.FirmName;
                ws.Cells[row, col++].Value = en.ContactNumber;
                ws.Cells[row, col++].Value = en.PrimeEmergingPrimeEmergingName;
                ws.Cells[row, col++].Value = en.Location;
                ws.Cells[row, col++].Value = en.InhouseBankInHouseBankType;
                ws.Cells[row, col++].Value = en.LogInLoanStatusLogInLoanStatusName;
                ws.Cells[row, col++].Value = en.Remark;
                ws.Cells[row, col++].Value = en.AdditionalInformation;
                ws.Cells[row, col++].Value = en.SystemLoginDate?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.UnderwritingDate?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.SalesManager;
                ws.Cells[row, col++].Value = en.NatureOfBusinessProfile;
                ws.Cells[row, col++].Value = en.ToPreviousYear;
                ws.Cells[row, col++].Value = en.ToLatestYear;
                ws.Cells[row, col++].Value = en.DisbursementDate?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.LoanAccountNumber;
                //ws.Cells[row, col++].Value = en.QaStatus;
                //ws.Cells[row, col++].Value = en.DeliveryStatus;
                //ws.Cells[row, col++].Value = en.AgentName;
                //ws.Cells[row, col++].Value = en.QaName;
                //ws.Cells[row, col++].Value = en.CallDate?.ToString("yyyy-MM-dd");
                //ws.Cells[row, col++].Value = en.DateAudited?.ToString("yyyy-MM-dd");
                //ws.Cells[row, col++].Value = en.DeliveryDate?.ToString("yyyy-MM-dd");
                //ws.Cells[row, col++].Value = en.Source;
                //ws.Cells[row, col++].Value = en.VerificationMode;
                //ws.Cells[row, col++].Value = en.Asset1;
                //ws.Cells[row, col++].Value = en.Asset2;
                //ws.Cells[row, col++].Value = en.TlName;
                //ws.Cells[row, col++].Value = en.Tenurity;
                //ws.Cells[row, col++].Value = en.Code;
                //ws.Cells[row, col++].Value = en.Link;                
                ws.Cells[row, col++].Value = en.OwnerId;
                ws.Cells[row, col++].Value = en.AssignedId;
                row++;
            }
            ws.Cells.AutoFitColumns();
            return package.GetAsByteArray();
        }
    }
}
