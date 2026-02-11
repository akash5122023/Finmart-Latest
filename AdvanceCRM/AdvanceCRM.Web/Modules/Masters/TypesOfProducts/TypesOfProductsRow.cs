using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[TypesOfProducts]")]
    [DisplayName("Types Of Products"), InstanceName("Types Of Products")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.TypesOfProducts", Permission = "?")]
    public sealed class TypesOfProductsRow : Row<TypesOfProductsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Product Type Name"), Size(200), QuickSearch, NameProperty]
        public String ProductTypeName
        {
            get => fields.ProductTypeName[this];
            set => fields.ProductTypeName[this] = value;
        }

        public TypesOfProductsRow()
            : base()
        {
        }

        public TypesOfProductsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField ProductTypeName;
        }
    }
}
