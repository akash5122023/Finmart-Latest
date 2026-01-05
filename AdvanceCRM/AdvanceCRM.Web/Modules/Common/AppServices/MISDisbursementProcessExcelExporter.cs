
using AdvanceCRM.Operations;
using OfficeOpenXml;
using System.Collections.Generic;

namespace AdvanceCRM.Web.Modules.Common.AppServices
{
    public class MISDisbursementProcessExcelExporter
    {
        public static byte[] ExportToExcel(List<MisDisbursementProcessRow> misdisbursementprocessrow)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using var package = new ExcelPackage();
            var ws = package.Workbook.Worksheets.Add("Quality");
            // Headers
            string[] headers = new[]
            {
            "Id","ContactPerson In Team","Year", "Month Name", "Bank Name", "Source Name", "Customer Name", "Bank Name", "Amount", "Net Amount", "Disbursement Status", "AdvanceEmi", "SubInsurancePf", "ProductId", "PrimeEmergingId","Contact Number", "Location", "Direct OR Indirect", "Employee Name", "Loan Account Number","ConfirmationMail TakenOrNot","AgreementSigning Person","Additional Information","CREATED BY","Assigned To"
        };
            for (int i = 0; i < headers.Length; i++)
                ws.Cells[1, i + 1].Value = headers[i];
            int row = 2;
            foreach (var en in misdisbursementprocessrow)
            {
                int col = 1;
                ws.Cells[row, col++].Value = en.Id;
                ws.Cells[row, col++].Value = en.ContactPersonInTeam;
                ws.Cells[row, col++].Value = en.Year;
                ws.Cells[row, col++].Value = en.MonthMonthsName;
                ws.Cells[row, col++].Value = en.BankNameBankNames;
                ws.Cells[row, col++].Value = en.SourceName;
                ws.Cells[row, col++].Value = en.CustomerName;
                ws.Cells[row, col++].Value = en.BankSourceOrCompanyName;
                ws.Cells[row, col++].Value = en.Amount;
                ws.Cells[row, col++].Value = en.NetAmt;
                ws.Cells[row, col++].Value = en.MisDisbursementStatusMisDisbursementStatusType;
                ws.Cells[row, col++].Value = en.AdvanceEmi;
                ws.Cells[row, col++].Value = en.SubInsurancePf;
                ws.Cells[row, col++].Value = en.ProductProductTypeName;
                ws.Cells[row, col++].Value = en.PrimeEmergingPrimeEmergingName;
                //ws.Cells[row, col++].Value = en.AssignedLocation;
                //ws.Cells[row, col++].Value = en.InhouseBankInHouseBankType;
                ws.Cells[row, col++].Value = en.ContactNumber;
                ws.Cells[row, col++].Value = en.Location;
                ws.Cells[row, col++].Value = en.MisDirectIndirectMisDirectIndirectType;
                ws.Cells[row, col++].Value = en.EmployeeName;
                ws.Cells[row, col++].Value = en.LoanAccountNumber;
                ws.Cells[row, col++].Value = en.ConfirmationMailTakenOrNot;
                ws.Cells[row, col++].Value = en.AgreementSigningPersonName;
                ws.Cells[row, col++].Value = en.AdditionalInformation;
                ws.Cells[row, col++].Value = en.OwnerUsername;
                ws.Cells[row, col++].Value = en.AssignedId;
                row++;
            }
            ws.Cells.AutoFitColumns();
            return package.GetAsByteArray();
        }
    }
}
