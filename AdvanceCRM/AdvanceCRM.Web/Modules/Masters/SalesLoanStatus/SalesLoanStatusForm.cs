using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.SalesLoanStatus")]
    [BasedOnRow(typeof(SalesLoanStatusRow), CheckNames = true)]
    public class SalesLoanStatusForm
    {
        public String SalesLoanStatusName { get; set; }
    }
}