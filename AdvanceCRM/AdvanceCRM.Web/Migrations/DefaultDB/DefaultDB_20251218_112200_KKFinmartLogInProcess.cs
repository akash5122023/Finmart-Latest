using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20251218112200)]
    public class DefaultDB_20251218_112200_KKFinmartLogInProcess : Migration
    {
        public override void Up()
        {
            Create.Table("MISLogInProcess")
                .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("SrNo").AsString(50).Nullable()
                .WithColumn("SourceName").AsString(200).Nullable()
                .WithColumn("CustomerName").AsString(200).Nullable()
                .WithColumn("FirmName").AsString(200).Nullable()
                .WithColumn("BankSourceOrCompanyName").AsString(200).Nullable()

                // Handling / Team / Location
                .WithColumn("FileHandledBy").AsString(150).Nullable()
                .WithColumn("ContactPersonInTeam").AsString(150).Nullable()
                .WithColumn("SalesManager").AsString(150).Nullable()
                .WithColumn("Location").AsString(150).Nullable()

                // Product / Requirement / Business
                .WithColumn("ProductId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_ProductId_Id", "dbo", "TypesOfProducts", "Id")
                .WithColumn("Requirement").AsString(500).Nullable()
                .WithColumn("NatureOfBusinessProfile").AsString(500).Nullable()
                .WithColumn("ProfileOfTheLead").AsString(500).Nullable()
                .WithColumn("BusinessVintage").AsString(100).Nullable()
                .WithColumn("BusinessDetailId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_BusinessDetailId_Id", "dbo", "BusinessDetails", "Id")
                .WithColumn("CompanyTypeId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_CompanytypeId_Id", "dbo", "TypesOfCompanies", "Id")
                .WithColumn("AccountTypeId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_AccountTypeId_Id", "dbo", "TypesOfAccounts", "Id")

                // Dates
                .WithColumn("FileReceivedDateTime").AsDateTime().Nullable()
                .WithColumn("QueriesGivenTime").AsDateTime().Nullable()
                .WithColumn("FileCompletionDateTime").AsDateTime().Nullable()
                .WithColumn("SystemLoginDate").AsDateTime().Nullable()
                .WithColumn("UnderwritingDate").AsDateTime().Nullable()
                .WithColumn("DisbursementDate").AsDateTime().Nullable()

                // Year / Month dropdowns
                .WithColumn("Year").AsString(10).Nullable()
                .WithColumn("MonthId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_MonthId_Id", "dbo", "MonthsInYear", "Id")

                // Bank / Financial
                .WithColumn("BankNameId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_BankNameId_Id", "dbo", "BankName", "Id")
                .WithColumn("LoanAccountNumber").AsString(200).Nullable()
                .WithColumn("PrimeEmergingId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_PrimeEmergingId_Id", "dbo", "PrimeEmerging", "Id")
                .WithColumn("MISDirectIndirectId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_MISDirectIndirectId_Id", "dbo", "MISDirectIndirect", "Id")
                .WithColumn("InhouseBankId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_InhouseBankId_Id", "dbo", "InHouseBank", "Id")
                .WithColumn("LoanAmount").AsDecimal().Nullable()
                .WithColumn("Amount").AsDecimal().Nullable()
                .WithColumn("NetAmt").AsDecimal().Nullable()
                .WithColumn("AdvanceEMI").AsDecimal().Nullable()
                .WithColumn("TOPreviousYear").AsDecimal().Nullable()
                .WithColumn("TOLatestYear").AsDecimal().Nullable()

                // Contact Information
                //.WithColumn("ContactNo").AsString(50).Nullable()
                .WithColumn("ContactNumber").AsString(50).Nullable()
                .WithColumn("CompanyMailId").AsString(200).Nullable()
                .WithColumn("EmployeeName").AsString(150).Nullable()

                // Agreements / Confirmation
                .WithColumn("ConfirmationMailTakenOrNot").AsString(10).Nullable()
                .WithColumn("AgreementSigningPersonName").AsString(150).Nullable()

                // Status / Remarks
                .WithColumn("LogInLoanStatusId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_LogInLoanStatusId_Id", "dbo", "LogInLoanStatus", "Id")
                .WithColumn("SalesLoanStatusId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_SalesLoanStatusId_Id", "dbo", "SalesLoanStatus", "Id")
                .WithColumn("MISDisbursementStatusId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_MISDisbursementStatusId_Id", "dbo", "MISDisbursementStatus", "Id")
                .WithColumn("Remark").AsString(500).Nullable()
                .WithColumn("StageOfTheCase").AsString(150).Nullable()
                .WithColumn("SubInsurancePF").AsString(200).Nullable()

            .WithColumn("OwnerId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_OwnerId_UserId", "dbo", "Users", "UserId")
            .WithColumn("AssignedId").AsInt32().Nullable().ForeignKey("FK_MISLogInProcess_AssignedId_UserId", "dbo", "Users", "UserId");

        }
        public override void Down()
        {           
        }
    }
}
