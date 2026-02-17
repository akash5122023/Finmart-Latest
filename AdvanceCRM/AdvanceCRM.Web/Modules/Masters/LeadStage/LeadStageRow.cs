using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[LeadStage]")]
    [DisplayName("Lead Stage"), InstanceName("Lead Stage")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.LeadStage", Permission = "?")]
    public sealed class LeadStageRow : Row<LeadStageRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Lead Stage Name"), Size(200), QuickSearch, NameProperty]
        public String LeadStageName
        {
            get => fields.LeadStageName[this];
            set => fields.LeadStageName[this] = value;
        }

        public LeadStageRow()
            : base()
        {
        }

        public LeadStageRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField LeadStageName;
        }
    }
}
