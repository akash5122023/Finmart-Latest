using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Masters
{
    [ConnectionKey("Default"), Module("Masters"), TableName("[dbo].[CustomerApproval]")]
    [DisplayName("Customer Approval"), InstanceName("Customer Approval")]
    [ReadPermission("Masters:Read")]
    [ModifyPermission("Masters:Modify")]
    [LookupScript("Masters.CustomerApproval", Permission = "?")]
    public sealed class CustomerApprovalRow : Row<CustomerApprovalRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, IdProperty]
        public Int32? Id
        {
            get => fields.Id[this];
            set => fields.Id[this] = value;
        }

        [DisplayName("Customer Approval Type"), Size(200), QuickSearch, NameProperty]
        public String CustomerApprovalType
        {
            get => fields.CustomerApprovalType[this];
            set => fields.CustomerApprovalType[this] = value;
        }

        public CustomerApprovalRow()
            : base()
        {
        }

        public CustomerApprovalRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField CustomerApprovalType;
        }
    }
}
