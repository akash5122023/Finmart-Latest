using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[InHouseBank]")]
    [DisplayName("In House Bank"), InstanceName("In House Bank")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.InHouseBank")]
    public sealed class InHouseBankRow : Row<InHouseBankRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("In House Bank Type"), Size(200), QuickSearch, NameProperty]
        public String InHouseBankType
        {
            get => fields.InHouseBankType[this];
            set => fields.InHouseBankType[this] = value;
        }

        public InHouseBankRow()
            : base()
        {
        }

        public InHouseBankRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField InHouseBankType;
        }
    }
}
