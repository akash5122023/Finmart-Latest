
using AdvanceCRM.FinmartInsideSales;
using OfficeOpenXml;
using System.Collections.Generic;

namespace AdvanceCRM.Web.Modules.Common.AppServices
{
    public class InsideSalesExcelExporter
    {
        public static byte[] ExportToExcel(List<InsideSalesRow> insidesalesrow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("Quality");
            // Headers
            string[] headers = new[]
            {
            "Id","Month Name", "FileReceivedDateTime", "Company Name", "Company Type", "ProfileOfTheLead", "ContactNumber", "CompanyMailId", "Product Type", "NatureOfBusinessProfile", "BusinessVintage", "Business Detail Type", "Account Type", "Sales Loan Status", "Loan Amount", "Remark","Additional Information", "StageOfTheCase", "Created By", "Assigned To"
        };
            for (int i = 0; i < headers.Length; i++)
                ws.Cells[1, i + 1].Value = headers[i];
            int row = 2;
            foreach (var en in insidesalesrow)
            {
                int col = 1;
                ws.Cells[row, col++].Value = en.Id;
                ws.Cells[row, col++].Value = en.MonthMonthsName;
                ws.Cells[row, col++].Value = en.FileReceivedDateTime?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.FirmName;
                ws.Cells[row, col++].Value = en.CompanyTypeCompanyTypeName;
                ws.Cells[row, col++].Value = en.ProfileOfTheLead;
                ws.Cells[row, col++].Value = en.ContactNumber;
                ws.Cells[row, col++].Value = en.CompanyMailId;
                ws.Cells[row, col++].Value = en.ProductProductTypeName;
                ws.Cells[row, col++].Value = en.NatureOfBusinessProfile;
                ws.Cells[row, col++].Value = en.BusinessVintage;
                ws.Cells[row, col++].Value = en.BusinessDetailBusinessDetailType;
                ws.Cells[row, col++].Value = en.AccountTypeAccountTypeName;
                ws.Cells[row, col++].Value = en.SalesLoanStatusSalesLoanStatusName;
                ws.Cells[row, col++].Value = en.LoanAmount;
                ws.Cells[row, col++].Value = en.Remark;
                ws.Cells[row, col++].Value = en.AdditionalInformation;
                ws.Cells[row, col++].Value = en.StageOfTheCaseCasesStageName;
                ws.Cells[row, col++].Value = en.OwnerUsername;
                ws.Cells[row, col++].Value = en.AssignedUsername;               
                row++;
            }
            ws.Cells.AutoFitColumns();
            return package.GetAsByteArray();
        }
    }
}
