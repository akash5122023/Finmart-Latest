using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[PrimeEmerging]")]
    [DisplayName("Prime Emerging"), InstanceName("Prime Emerging")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.PrimeEmerging")]
    public sealed class PrimeEmergingRow : Row<PrimeEmergingRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Prime Emerging Name"), Size(200), QuickSearch, NameProperty]
        public String PrimeEmergingName
        {
            get => fields.PrimeEmergingName[this];
            set => fields.PrimeEmergingName[this] = value;
        }

        public PrimeEmergingRow()
            : base()
        {
        }

        public PrimeEmergingRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField PrimeEmergingName;
        }
    }
}
