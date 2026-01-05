using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Operations.Columns
{
    [ColumnsScript("Operations.MisInitialProcess")]
    [BasedOnRow(typeof(MisInitialProcessRow), CheckNames = true)]
    public class MisInitialProcessColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        [Width(120), EditLink, QuickFilter, QuickSearch]

        public String ContactsName { get; set; }
        [QuickSearch]
        public String ContactsPhone { get; set; }
        [QuickSearch]
        public String ContactsEmail { get; set; }
        public String ContactsAddress { get; set; }
        public String SourceName { get; set; }
        public String CustomerName { get; set; }
        public String FirmName { get; set; }
        [LookupEditor(typeof(TypesOfProductsRow))]
        public Int32 ProductId { get; set; }
        //public String ProductProductTypeName { get; set; }
        public String Requirement { get; set; }
        public DateTime FileReceivedDateTime { get; set; }
        public DateTime QueriesGivenTime { get; set; }
        public DateTime FileCompletionDateTime { get; set; }
        //public String ContactsState { get; set; }
        //public String ContactsCity { get; set; }
       // public String ContactsArea { get; set; }
        public String OwnerUsername { get; set; }
        public String AssignedUsername { get; set; }
    }
}