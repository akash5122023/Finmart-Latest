using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.MonthsInYear")]
    [BasedOnRow(typeof(MonthsInYearRow), CheckNames = true)]
    public class MonthsInYearForm
    {
        public String MonthsName { get; set; }
    }
}