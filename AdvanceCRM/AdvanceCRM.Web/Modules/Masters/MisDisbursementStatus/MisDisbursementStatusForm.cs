using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.MisDisbursementStatus")]
    [BasedOnRow(typeof(MisDisbursementStatusRow), CheckNames = true)]
    public class MisDisbursementStatusForm
    {
        public String MisDisbursementStatusType { get; set; }
    }
}