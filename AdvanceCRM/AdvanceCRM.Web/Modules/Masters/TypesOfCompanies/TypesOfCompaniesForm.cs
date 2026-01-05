using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.TypesOfCompanies")]
    [BasedOnRow(typeof(TypesOfCompaniesRow), CheckNames = true)]
    public class TypesOfCompaniesForm
    {
        public String CompanyTypeName { get; set; }
    }
}