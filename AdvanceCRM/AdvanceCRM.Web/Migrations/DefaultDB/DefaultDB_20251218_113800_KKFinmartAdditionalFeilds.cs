using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20251218113800)]
    public class DefaultDB_20251218_113800_KKFinmartAdditionalFeilds : Migration
    {
        public override void Up()
        {
            Alter.Table("MISDisbursementProcess")
                 .AddColumn("AdditionalInformation").AsString(200).Nullable();

            Alter.Table("MISLogInProcess")
                .AddColumn("AdditionalInformation").AsString(200).Nullable();

            Alter.Table("MISInitialProcess")
                .AddColumn("AdditionalInformation").AsString(200).Nullable();

            Alter.Table("InsideSales")
                .AddColumn("AdditionalInformation").AsString(200).Nullable();
        }

        public override void Down()
        {
        }
    }
}
