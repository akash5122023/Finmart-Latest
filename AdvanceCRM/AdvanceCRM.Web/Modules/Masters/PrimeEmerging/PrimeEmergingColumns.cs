using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Columns
{
    [ColumnsScript("Masters.PrimeEmerging")]
    [BasedOnRow(typeof(PrimeEmergingRow), CheckNames = true)]
    public class PrimeEmergingColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String PrimeEmergingName { get; set; }
    }
}