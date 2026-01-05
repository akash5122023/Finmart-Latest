using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace AdvanceCRM.Masters.Columns
{
    [ColumnsScript("Masters.MisDisbursementStatus")]
    [BasedOnRow(typeof(MisDisbursementStatusRow), CheckNames = true)]
    public class MisDisbursementStatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [EditLink]
        public String MisDisbursementStatusType { get; set; }
    }
}