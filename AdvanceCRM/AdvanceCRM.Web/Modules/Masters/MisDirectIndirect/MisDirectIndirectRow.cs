using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[MISDirectIndirect]")]
    [DisplayName("Mis Direct Indirect"), InstanceName("Mis Direct Indirect")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.MISDirectIndirect")]
    public sealed class MisDirectIndirectRow : Row<MisDirectIndirectRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Mis Direct Indirect Type"), Column("MISDirectIndirectType"), Size(200), QuickSearch, NameProperty]
        public String MisDirectIndirectType
        {
            get => fields.MisDirectIndirectType[this];
            set => fields.MisDirectIndirectType[this] = value;
        }

        public MisDirectIndirectRow()
            : base()
        {
        }

        public MisDirectIndirectRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField MisDirectIndirectType;
        }
    }
}
