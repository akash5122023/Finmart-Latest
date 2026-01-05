using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.PrimeEmerging")]
    [BasedOnRow(typeof(PrimeEmergingRow), CheckNames = true)]
    public class PrimeEmergingForm
    {
        public String PrimeEmergingName { get; set; }
    }
}