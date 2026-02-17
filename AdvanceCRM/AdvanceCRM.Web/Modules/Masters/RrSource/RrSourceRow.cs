using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[RRSource]")]
    [DisplayName("RR Source"), InstanceName("Rr Source")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.RRSource", Permission = "?")]
    public sealed class RrSourceRow : Row<RrSourceRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Source Name"), Size(200), QuickSearch, NameProperty]
        public String SourceName
        {
            get => fields.SourceName[this];
            set => fields.SourceName[this] = value;
        }

        public RrSourceRow()
            : base()
        {
        }

        public RrSourceRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SourceName;
        }
    }
}
