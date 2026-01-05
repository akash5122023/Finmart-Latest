using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.BusinessDetails")]
    [BasedOnRow(typeof(BusinessDetailsRow), CheckNames = true)]
    public class BusinessDetailsForm
    {
        public String BusinessDetailType { get; set; }
    }
}