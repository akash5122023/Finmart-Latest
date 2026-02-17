using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.RrSource")]
    [BasedOnRow(typeof(RrSourceRow), CheckNames = true)]
    public class RrSourceForm
    {
        public String SourceName { get; set; }
    }
}