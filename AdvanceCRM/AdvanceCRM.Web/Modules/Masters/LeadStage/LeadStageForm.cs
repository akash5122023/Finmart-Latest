using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.LeadStage")]
    [BasedOnRow(typeof(LeadStageRow), CheckNames = true)]
    public class LeadStageForm
    {
        public String LeadStageName { get; set; }
    }
}