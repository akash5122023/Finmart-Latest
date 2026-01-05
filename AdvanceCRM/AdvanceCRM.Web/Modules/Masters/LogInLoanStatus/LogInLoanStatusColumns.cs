using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Columns
{
    [ColumnsScript("Masters.LogInLoanStatus")]
    [BasedOnRow(typeof(LogInLoanStatusRow), CheckNames = true)]
    public class LogInLoanStatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String LogInLoanStatusName { get; set; }
    }
}