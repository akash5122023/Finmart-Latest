using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20260217131200)]
    public class DefaultDB_20260217_131200_KKInitialSourceModified : Migration
    {
        public override void Up()
        {
            Create.Table("CustomerApproval")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("CustomerApprovalType").AsString(200).Nullable();

            Alter.Table("MISInitialProcess")
                 .AddColumn("RRSourceId").AsInt32().Nullable();

            Create.ForeignKey("FK_MISInitialProcess_RRSourceId")
                .FromTable("MISInitialProcess").ForeignColumn("RRSourceId")
                .ToTable("RRSource").PrimaryColumn("Id");           

            Alter.Table("MISLogInProcess")
                 .AddColumn("RRSourceId").AsInt32().Nullable();

            Alter.Table("MISDisbursementProcess")
                 .AddColumn("RRSourceId").AsInt32().Nullable();

            Create.ForeignKey("FK_MISLogInProcess_RRSourceId")
                .FromTable("MISLogInProcess").ForeignColumn("RRSourceId")
                .ToTable("RRSource").PrimaryColumn("Id");

            Create.ForeignKey("FK_MISDisbursementProcess_RRSourceId")
               .FromTable("MISDisbursementProcess").ForeignColumn("RRSourceId")
               .ToTable("RRSource").PrimaryColumn("Id");

            Alter.Table("MISDisbursementProcess")
              .AddColumn("CustomerApprovalId").AsInt32().Nullable();

            Create.ForeignKey("FK_MISDisbursementProcess_CustomerApprovalId")
               .FromTable("MISDisbursementProcess").ForeignColumn("CustomerApprovalId")
               .ToTable("CustomerApproval").PrimaryColumn("Id");
        }

        public override void Down()
        {
        }
    }
}
