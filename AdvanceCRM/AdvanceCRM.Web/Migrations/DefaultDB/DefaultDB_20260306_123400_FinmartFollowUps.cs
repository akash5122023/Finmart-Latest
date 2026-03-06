using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20260306123400)]
    public class DefaultDB_20260306_123400_FinmartFollowUps : Migration
    {
        public override void Up()
        {
            Create.Table("InsideSalesFollowups")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("FollowupNote").AsString(200).NotNullable()
                .WithColumn("Details").AsString(2000)
                .WithColumn("FollowupDate").AsDateTime().NotNullable()
                .WithColumn("ClosingDate").AsDateTime().NotNullable()
                .WithColumn("Status").AsInt32().NotNullable()
                .WithColumn("InsideSalesId").AsInt32().NotNullable().ForeignKey("FK_InsideSalesFollowups_InsideSalesId", "dbo", "InsideSales", "Id")
                .WithColumn("RepresentativeId").AsInt32().Nullable().ForeignKey("FK_InsideSalesFollowups_UserId", "dbo", "Users", "UserId");

            Create.Table("ChannelPartnerFollowups")
                  .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                  .WithColumn("FollowupNote").AsString(200).NotNullable()
                  .WithColumn("Details").AsString(2000)
                  .WithColumn("FollowupDate").AsDateTime().NotNullable()
                  .WithColumn("ClosingDate").AsDateTime().NotNullable()
                  .WithColumn("Status").AsInt32().NotNullable()
                  .WithColumn("ChannelPartnerId").AsInt32().NotNullable().ForeignKey("FK_ChannelPartnerFollowups_ChannelPartnerId", "dbo", "ChannelPartner", "Id")
                  .WithColumn("RepresentativeId").AsInt32().Nullable().ForeignKey("FK_ChannelPartnerFollowups_UserId", "dbo", "Users", "UserId");

        }

        public override void Down()
        {
           
        }
    }
}
