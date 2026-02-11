using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[CasesStage]")]
    [DisplayName("Cases Stage"), InstanceName("Cases Stage")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.CasesStage", Permission = "?")]
    public sealed class CasesStageRow : Row<CasesStageRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Cases Stage Name"), Size(200), QuickSearch, NameProperty]
        public String CasesStageName
        {
            get => fields.CasesStageName[this];
            set => fields.CasesStageName[this] = value;
        }

        public CasesStageRow()
            : base()
        {
        }

        public CasesStageRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField CasesStageName;
        }
    }
}
