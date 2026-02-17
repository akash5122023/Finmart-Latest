using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20260217104600)]
    public class DefaultDB_20260217_104600_KKInitialAdditionalFeilds : Migration
    {
        public override void Up()
        {
            Create.Table("LeadStage")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("LeadStageName").AsString(200).Nullable();

            Create.Table("RRSource")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("SourceName").AsString(200).Nullable();

            Alter.Table("MISInitialProcess")
                 .AddColumn("LeadStageId").AsInt32().Nullable();

            Create.ForeignKey("FK_MISInitialProcess_LeadStageId")
                .FromTable("MISInitialProcess").ForeignColumn("LeadStageId")
                .ToTable("LeadStage").PrimaryColumn("Id");           

            Alter.Table("MISLogInProcess")
                 .AddColumn("LeadStageId").AsInt32().Nullable();

            Alter.Table("MISDisbursementProcess")
                 .AddColumn("LeadStageId").AsInt32().Nullable();

            Alter.Table("InsideSales")
              .AddColumn("ContactsId").AsInt32().Nullable()
              .AddColumn("ContactPersonId").AsInt32().Nullable();

            Create.ForeignKey("FK_InsideSales_ContactsId")
                .FromTable("InsideSales").ForeignColumn("ContactsId")
                .ToTable("Contacts").PrimaryColumn("Id");

            Create.ForeignKey("FK_InsideSales_ContactPersonId")
                .FromTable("InsideSales").ForeignColumn("ContactPersonId")
                .ToTable("SubContacts").PrimaryColumn("Id");

            Alter.Table("MISLogInProcess")
              .AddColumn("CibilScore").AsInt32().Nullable();

            Alter.Table("MISDisbursementProcess")
              .AddColumn("CibilScore").AsInt32().Nullable();
        }

        public override void Down()
        {
        }
    }
}
