using FluentMigrator;

namespace AdvanceCRM.Migrations.DefaultDB
{
    [Migration(20260224150000)]
    public class DefaultDB_20260224_150000_ContactsMultiProduct : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("ContactsMultiProduct")
                .WithColumn("Id").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("ContactsId").AsInt32().NotNullable()
                    .ForeignKey("FK_ContactsMultiProduct_Contacts", "Contacts", "Id")
                .WithColumn("ProductId").AsInt32().NotNullable()
                    .ForeignKey("FK_ContactsMultiProduct_TypesOfProducts", "TypesOfProducts", "Id");

            Create.Index("IX_ContactsMultiProduct_ContactsId")
                .OnTable("ContactsMultiProduct")
                .OnColumn("ContactsId");

            Create.Index("IX_ContactsMultiProduct_ProductId")
                .OnTable("ContactsMultiProduct")
                .OnColumn("ProductId");
        }
    }
}
