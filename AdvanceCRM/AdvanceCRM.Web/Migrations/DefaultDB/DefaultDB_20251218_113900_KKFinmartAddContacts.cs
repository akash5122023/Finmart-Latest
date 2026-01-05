using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20251218113900)]
    public class DefaultDB_20251218_113900_KKFinmartAddContacts : Migration
    {
        public override void Up()
        {
            Alter.Table("MISInitialProcess")
              .AddColumn("ContactsId").AsInt32().Nullable()
              .AddColumn("ContactPersonId").AsInt32().Nullable();

            Create.ForeignKey("FK_MISInitialProcess_ContactsId")
                .FromTable("MISInitialProcess").ForeignColumn("ContactsId")
                .ToTable("Contacts").PrimaryColumn("Id");

            Create.ForeignKey("FK_MISInitialProcess_ContactPersonId")
                .FromTable("MISInitialProcess").ForeignColumn("ContactPersonId")
                .ToTable("SubContacts").PrimaryColumn("Id");
        }

        public override void Down()
        {
        }
    }
}
