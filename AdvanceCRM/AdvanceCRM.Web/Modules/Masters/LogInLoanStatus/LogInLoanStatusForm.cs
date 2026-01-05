using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.LogInLoanStatus")]
    [BasedOnRow(typeof(LogInLoanStatusRow), CheckNames = true)]
    public class LogInLoanStatusForm
    {
        public String LogInLoanStatusName { get; set; }
    }
}