using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20260223181500)]
    public class DefaultDB_20260223_181500_ChannelPartner : Migration
    {
        public override void Up()
        {   
            Create.Table("ChannelPartner")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("BankNameId").AsInt32().Nullable().ForeignKey("FK_ChannelPartner_BankNameId_Id", "dbo", "BankName", "Id")
                .WithColumn("BankSalesManagerName").AsString(255).Nullable()
                .WithColumn("ProductId").AsInt32().Nullable().ForeignKey("FK_ChannelPartner_ProductId_Id", "dbo", "TypesOfProducts", "Id")
                .WithColumn("LoanAmount").AsDecimal().Nullable()
                .WithColumn("LoginDate").AsDateTime().Nullable()
                .WithColumn("MISDisbursementStatusId").AsInt32().Nullable().ForeignKey("FK_ChannelPartner_MISDisbursementStatusId_Id", "dbo", "MISDisbursementStatus", "Id")
                .WithColumn("DisbursementDate").AsDateTime().Nullable()
                .WithColumn("DisbursedAmount").AsDecimal().Nullable()
                .WithColumn("OwnerId").AsInt32().Nullable().ForeignKey("FK_ChannelPartner_OwnerId_UserId", "dbo", "Users", "UserId");

            Alter.Table("Contacts")
                 .AddColumn("ProductId").AsInt32().Nullable().ForeignKey("FK_Contacts_ProductId_Id", "dbo", "TypesOfProducts", "Id");
        }

        public override void Down()
        {
           
        }
    }
}
