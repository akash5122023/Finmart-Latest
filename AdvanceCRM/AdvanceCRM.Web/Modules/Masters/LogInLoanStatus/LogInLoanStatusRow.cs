using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[LogInLoanStatus]")]
    [DisplayName("Log In Loan Status"), InstanceName("Log In Loan Status")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.LogInLoanStatus", Permission = "?")]
    public sealed class LogInLoanStatusRow : Row<LogInLoanStatusRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Log In Loan Status Name"), Size(200), QuickSearch, NameProperty]
        public String LogInLoanStatusName
        {
            get => fields.LogInLoanStatusName[this];
            set => fields.LogInLoanStatusName[this] = value;
        }

        public LogInLoanStatusRow()
            : base()
        {
        }

        public LogInLoanStatusRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField LogInLoanStatusName;
        }
    }
}
