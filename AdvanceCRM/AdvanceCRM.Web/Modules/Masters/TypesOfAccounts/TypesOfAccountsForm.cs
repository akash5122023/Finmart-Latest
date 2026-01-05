using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.TypesOfAccounts")]
    [BasedOnRow(typeof(TypesOfAccountsRow), CheckNames = true)]
    public class TypesOfAccountsForm
    {
        public String AccountTypeName { get; set; }
    }
}