using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.MisDirectIndirect")]
    [BasedOnRow(typeof(MisDirectIndirectRow), CheckNames = true)]
    public class MisDirectIndirectForm
    {
        public String MisDirectIndirectType { get; set; }
    }
}