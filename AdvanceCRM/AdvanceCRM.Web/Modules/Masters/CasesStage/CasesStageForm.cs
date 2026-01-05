using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.CasesStage")]
    [BasedOnRow(typeof(CasesStageRow), CheckNames = true)]
    public class CasesStageForm
    {
        public String CasesStageName { get; set; }
    }
}