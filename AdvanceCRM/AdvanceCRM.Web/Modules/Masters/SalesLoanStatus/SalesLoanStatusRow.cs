using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[SalesLoanStatus]")]
    [DisplayName("Sales Loan Status"), InstanceName("Sales Loan Status")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.SalesLoanStatus", Permission = "?")]
    public sealed class SalesLoanStatusRow : Row<SalesLoanStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Sales Loan Status Name"), Size(200), QuickSearch, NameProperty]
        public String SalesLoanStatusName
        {
            get => fields.SalesLoanStatusName[this];
            set => fields.SalesLoanStatusName[this] = value;
        }

        public SalesLoanStatusRow()
            : base()
        {
        }

        public SalesLoanStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SalesLoanStatusName;
        }
    }
}
