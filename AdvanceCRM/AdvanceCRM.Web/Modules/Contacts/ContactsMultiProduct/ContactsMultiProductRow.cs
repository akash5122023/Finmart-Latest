
namespace AdvanceCRM.Contacts
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("Contacts"), TableName("[dbo].[ContactsMultiProduct]")]
    [DisplayName("Contacts Multi Product"), InstanceName("Contacts Multi Product")]
    [ReadPermission("Contacts:Read")]
    [InsertPermission("Contacts:Insert")]
    [UpdatePermission("Contacts:Update")]
    [DeletePermission("Contacts:Delete")]
    public sealed class ContactsMultiProductRow : Row<ContactsMultiProductRow.RowFields>, IIdRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Product"), NotNull, ForeignKey("[dbo].[TypesOfProducts]", "Id"), LeftJoin("jProduct"), TextualField("ProductTypeName")]
        public Int32? ProductId
        {
            get { return Fields.ProductId[this]; }
            set { Fields.ProductId[this] = value; }
        }

        [DisplayName("Contacts"), NotNull, ForeignKey("[dbo].[Contacts]", "Id"), LeftJoin("jContacts"), TextualField("ContactsName")]
        public Int32? ContactsId
        {
            get { return Fields.ContactsId[this]; }
            set { Fields.ContactsId[this] = value; }
        }

        [DisplayName("Product Type Name"), Expression("jProduct.[ProductTypeName]")]
        public String ProductTypeName
        {
            get { return Fields.ProductTypeName[this]; }
            set { Fields.ProductTypeName[this] = value; }
        }

        [DisplayName("Contacts Name"), Expression("jContacts.[Name]")]
        public String ContactsName
        {
            get { return Fields.ContactsName[this]; }
            set { Fields.ContactsName[this] = value; }
        }

        public ContactsMultiProductRow()
            : base(Fields)
        {
        }

        public ContactsMultiProductRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ProductId;
            public Int32Field ContactsId;
            public StringField ProductTypeName;
            public StringField ContactsName;
        }
    }
}
