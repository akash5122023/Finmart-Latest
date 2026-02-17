using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.CustomerApproval")]
    [BasedOnRow(typeof(CustomerApprovalRow), CheckNames = true)]
    public class CustomerApprovalForm
    {
        public String CustomerApprovalType { get; set; }
    }
}