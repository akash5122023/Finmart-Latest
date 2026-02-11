using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[TypesOfAccounts]")]
    [DisplayName("Types Of Accounts"), InstanceName("Types Of Accounts")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.TypesOfAccounts", Permission = "?")]
    public sealed class TypesOfAccountsRow : Row<TypesOfAccountsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Account Type Name"), Size(200), QuickSearch, NameProperty]
        public String AccountTypeName
        {
            get => fields.AccountTypeName[this];
            set => fields.AccountTypeName[this] = value;
        }

        public TypesOfAccountsRow()
            : base()
        {
        }

        public TypesOfAccountsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField AccountTypeName;
        }
    }
}
