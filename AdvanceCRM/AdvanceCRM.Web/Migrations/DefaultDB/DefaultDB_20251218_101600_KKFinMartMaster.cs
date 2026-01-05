using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20251218101600)]
    public class DefaultDB_20251218_101600_KKFinMartMaster : Migration
    {
        public override void Up()
        {
            Create.Table("TypesOfCompanies")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("CompanyTypeName").AsString(200).Nullable();

            Create.Table("TypesOfProducts")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("ProductTypeName").AsString(200).Nullable();

            Create.Table("BusinessDetails")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("BusinessDetailType").AsString(200).Nullable();

            Create.Table("TypesOfAccounts")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("AccountTypeName").AsString(200).Nullable();

            Create.Table("LogInLoanStatus")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("LogInLoanStatusName").AsString(200).Nullable();

            Create.Table("SalesLoanStatus")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("SalesLoanStatusName").AsString(200).Nullable();

            Create.Table("BankName")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("BankNames").AsString(200).Nullable();

            Create.Table("PrimeEmerging")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("PrimeEmergingName").AsString(200).Nullable();

            Create.Table("InHouseBank")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("InHouseBankType").AsString(200).Nullable();

            Create.Table("MISDisbursementStatus")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("MISDisbursementStatusType").AsString(200).Nullable();

            Create.Table("MISDirectIndirect")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("MISDirectIndirectType").AsString(200).Nullable();

            Create.Table("MonthsInYear")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("MonthsName").AsString(200).Nullable();

            Create.Table("CasesStage")
              .WithColumn("Id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("CasesStageName").AsString(200).Nullable();
        }
        public override void Down()
        {           
        }
    }
}
