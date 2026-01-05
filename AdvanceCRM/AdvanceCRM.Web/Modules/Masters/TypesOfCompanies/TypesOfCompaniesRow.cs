using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[TypesOfCompanies]")]
    [DisplayName("Types Of Companies"), InstanceName("Types Of Companies")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.TypesOfCompanies")]
    public sealed class TypesOfCompaniesRow : Row<TypesOfCompaniesRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Company Type Name"), Size(200), QuickSearch, NameProperty]
        public String CompanyTypeName
        {
            get => fields.CompanyTypeName[this];
            set => fields.CompanyTypeName[this] = value;
        }

        public TypesOfCompaniesRow()
            : base()
        {
        }

        public TypesOfCompaniesRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField CompanyTypeName;
        }
    }
}
