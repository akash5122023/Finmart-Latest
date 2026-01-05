using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[BankName]")]
    [DisplayName("Bank Name"), InstanceName("Bank Name")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.BankName")]
    public sealed class BankNameRow : Row<BankNameRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Bank Names"), Size(200), QuickSearch, NameProperty]
        public String BankNames
        {
            get => fields.BankNames[this];
            set => fields.BankNames[this] = value;
        }

        public BankNameRow()
            : base()
        {
        }

        public BankNameRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField BankNames;
        }
    }
}
