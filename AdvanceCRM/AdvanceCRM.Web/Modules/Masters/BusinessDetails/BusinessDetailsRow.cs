using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[BusinessDetails]")]
    [DisplayName("Business Details"), InstanceName("Business Details")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.BusinessDetails", Permission = "?")]
    public sealed class BusinessDetailsRow : Row<BusinessDetailsRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Business Detail Type"), Size(200), QuickSearch, NameProperty]
        public String BusinessDetailType
        {
            get => fields.BusinessDetailType[this];
            set => fields.BusinessDetailType[this] = value;
        }

        public BusinessDetailsRow()
            : base()
        {
        }

        public BusinessDetailsRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField BusinessDetailType;
        }
    }
}
