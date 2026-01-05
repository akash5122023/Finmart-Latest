using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.BankName")]
    [BasedOnRow(typeof(BankNameRow), CheckNames = true)]
    public class BankNameForm
    {
        public String BankNames { get; set; }
    }
}