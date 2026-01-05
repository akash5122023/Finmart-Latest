using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[MonthsInYear]")]
    [DisplayName("Months In Year"), InstanceName("Months In Year")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.MonthsInYear")]
    public sealed class MonthsInYearRow : Row<MonthsInYearRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Months Name"), Size(200), QuickSearch, NameProperty]
        public String MonthsName
        {
            get => fields.MonthsName[this];
            set => fields.MonthsName[this] = value;
        }

        public MonthsInYearRow()
            : base()
        {
        }

        public MonthsInYearRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField MonthsName;
        }
    }
}
