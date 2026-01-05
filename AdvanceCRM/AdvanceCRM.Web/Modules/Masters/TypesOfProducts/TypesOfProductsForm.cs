using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Forms
{
    [FormScript("Masters.TypesOfProducts")]
    [BasedOnRow(typeof(TypesOfProductsRow), CheckNames = true)]
    public class TypesOfProductsForm
    {
        public String ProductTypeName { get; set; }
    }
}