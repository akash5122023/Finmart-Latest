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

        // Contacts Details
        [Width(150), EditLink, QuickFilter, QuickSearch]
        public String ContactsName { get; set; }
        [Width(120), QuickSearch]
        public String ContactsPhone { get; set; }
        [Width(120)]
        public String ContactPersonName { get; set; }
        [Width(120)]
        public String ContactPersonPhone { get; set; }

        // Basic Information
        [Width(120)]
        public String SourceName { get; set; }
        [Width(150)]
        public String CustomerName { get; set; }
        [Width(150)]
        public String FirmName { get; set; }
        [Width(120)]
        public String LeadStageName { get; set; }

        // Product / Requirement Details
        [Width(130)]
        public String ProductProductTypeName { get; set; }
        [Width(200)]
        public String Requirement { get; set; }

        // File Timing
        [Width(120)]
        public String BankNameBankNames { get; set; }
        [Width(100), AlignRight]
        public Decimal LoanAmount { get; set; }
        [Width(140)]
        public DateTime FileReceivedDateTime { get; set; }
        [Width(140)]
        public DateTime QueriesGivenTime { get; set; }
        [Width(140)]
        public DateTime FileCompletionDateTime { get; set; }
        [Width(200)]
        public String AdditionalInformation { get; set; }

        // Ownership / Assignment
        [Width(120)]
        public String OwnerUsername { get; set; }
        [Width(120)]
        public String AssignedUsername { get; set; }
    }
}