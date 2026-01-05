using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.InHouseBank")]
    [BasedOnRow(typeof(InHouseBankRow), CheckNames = true)]
    public class InHouseBankForm
    {
        public String InHouseBankType { get; set; }
    }
}