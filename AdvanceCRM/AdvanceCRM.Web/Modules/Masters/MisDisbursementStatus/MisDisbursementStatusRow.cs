using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[MISDisbursementStatus]")]
    [DisplayName("Mis Disbursement Status"), InstanceName("Mis Disbursement Status")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.MISDisbursementStatus")]
    public sealed class MisDisbursementStatusRow : Row<MisDisbursementStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Mis Disbursement Status Type"), Column("MISDisbursementStatusType"), Size(200), QuickSearch, NameProperty]
        public String MisDisbursementStatusType
        {
            get => fields.MisDisbursementStatusType[this];
            set => fields.MisDisbursementStatusType[this] = value;
        }

        public MisDisbursementStatusRow()
            : base()
        {
        }

        public MisDisbursementStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField MisDisbursementStatusType;
        }
    }
}
