
using AdvanceCRM.Operations;
using OfficeOpenXml;
using System.Collections.Generic;

namespace AdvanceCRM.Web.Modules.Common.AppServices
{
    public class MISInitialProcessExcelExporter
    {
        public static byte[] ExportToExcel(List<MisInitialProcessRow> misinitialprocessrow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("MisInitialProcess");
            // Headers
            string[] headers = new[]
            {
            "Id","Contacts Name","Contacts Phone","Contacts Email","Contacts Address","Source Name", "Customer Name", "Company Name", "Product Type", "Requirement", "FileReceivedDateTime", " QueriesGivenTime ", "FileCompletionDateTime ","Additional Information", "Created By", "Assigned To"
        };
            for (int i = 0; i < headers.Length; i++)
                ws.Cells[1, i + 1].Value = headers[i];
            int row = 2;
            foreach (var en in misinitialprocessrow)
            {
                int col = 1;
                ws.Cells[row, col++].Value = en.Id;
                ws.Cells[row, col++].Value = en.ContactPersonName;
                ws.Cells[row, col++].Value = en.ContactPersonPhone;
                ws.Cells[row, col++].Value = en.ContactPersonEmail;
                ws.Cells[row, col++].Value = en.ContactPersonAddress;
                ws.Cells[row, col++].Value = en.SourceName;
                ws.Cells[row, col++].Value = en.CustomerName;
                ws.Cells[row, col++].Value = en.FirmName;
                ws.Cells[row, col++].Value = en.ProductProductTypeName;
                ws.Cells[row, col++].Value = en.Requirement;
                ws.Cells[row, col++].Value = en.FileReceivedDateTime?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.QueriesGivenTime?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.FileCompletionDateTime?.ToString("dd-MMM-yyyy");
                ws.Cells[row, col++].Value = en.AdditionalInformation;
                //ws.Cells[row, col++].Value = en.ContactNumber;
                //ws.Cells[row, col++].Value = en.CompanyMailId;
                //ws.Cells[row, col++].Value = en.NatureOfBusinessProfile;
                //ws.Cells[row, col++].Value = en.BusinessVintage;
                //ws.Cells[row, col++].Value = en.BusinessDetailBusinessDetailType;
                //ws.Cells[row, col++].Value = en.AccountTypeAccountTypeName;
                //ws.Cells[row, col++].Value = en.SalesLoanStatusSalesLoanStatusName;
                //ws.Cells[row, col++].Value = en.LoanAmount;
                //ws.Cells[row, col++].Value = en.Remark;
                //ws.Cells[row, col++].Value = en.AdditionalInformation;
               // ws.Cells[row, col++].Value = en.StageOfTheCaseCasesStageName;
                ws.Cells[row, col++].Value = en.OwnerUsername;
                ws.Cells[row, col++].Value = en.AssignedUsername;
                //ws.Cells[row, col++].Value = en.OwnerUsername;
                row++;
            }
            ws.Cells.AutoFitColumns();
            return package.GetAsByteArray();
        }
    }
}
