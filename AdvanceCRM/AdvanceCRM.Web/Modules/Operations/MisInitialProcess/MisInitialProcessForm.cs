using AdvanceCRM.Administration;
using AdvanceCRM.Masters;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace AdvanceCRM.Operations.Forms
{
    [FormScript("Operations.MisInitialProcess")]
    [BasedOnRow(typeof(MisInitialProcessRow), CheckNames = true)]
    public class MisInitialProcessForm
    {
        [Category("Contact Details")]
        [HalfWidth]
        public Int32 ContactsId { get; set; }
        [Hidden]
        public Int32 ContactsContactType { get; set; }
        [Hidden]
        public String ContactsName { get; set; }

        [Hidden]
        public String ContactsEmail { get; set; }
        [HalfWidth, ReadOnly(true)]
        //[LookupEditor("Contacts.ContactPhoneLookup")]
        public String ContactsPhone { get; set; }
        [Hidden]
        public String ContactsWhatsapp { get; set; }
        [Hidden,ReadOnly(true)]
        public String ContactsAddress { get; set; }
        [HalfWidth, FormCssClass("line-break-sm")]
        public Int32 ContactPersonId { get; set; }
        [Hidden]
        public String ContactPersonName { get; set; }
        [ReadOnly(true), HalfWidth]
        public String ContactPersonPhone { get; set; }
        [Hidden]
        public String ContactPersonWhatsapp { get; set; }
        [Hidden,ReadOnly(true), HalfWidth]
        public String ContactPersonProject { get; set; }
        [Hidden,ReadOnly(true)]
        public String ContactPersonAddress { get; set; }
        [Category("Basic Information")]

        //[HalfWidth, DisplayName("Sr No")]
        //public Int32 SrNo { get; set; }

        [HalfWidth, DisplayName("Source Name")]
        public String SourceName { get; set; }

        [HalfWidth, DisplayName("Customer Name")]
        public String CustomerName { get; set; }

        [HalfWidth, DisplayName("Firm Name")]
        public String FirmName { get; set; }

        //[HalfWidth, LookupEditor(typeof(UserRow))]
        //[DisplayName("File Handled By")]
        //public Int32 FileHandledById { get; set; }

        // -------------------- PRODUCT / REQUIREMENT --------------------
        [Category("Product / Requirement Details")]

        [HalfWidth, LookupEditor(typeof(TypesOfProductsRow))]
        [DisplayName("Types of Product")]
        public Int32 ProductId { get; set; }

        [DisplayName("Requirement")]
        [TextAreaEditor(Rows = 5)]
        public String Requirement { get; set; }

        // -------------------- DATE / TIMING --------------------
        [Category("File Timing")]

        [HalfWidth, DisplayName("File Received Date & Time")]
        public DateTime FileReceivedDateTime { get; set; }

        [HalfWidth, DisplayName("Queries Given Time")]
        public DateTime QueriesGivenTime { get; set; }

        [HalfWidth, DisplayName("File Completion Date & Time")]
        public DateTime FileCompletionDateTime { get; set; }
        [FullWidth, TextAreaEditor(Rows = 2)]
        public String? AdditionalInformation { get; set; }
        [Category("Ownership / Assignment")]

        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Created By")]
        public Int32 OwnerId { get; set; }

        [HalfWidth, LookupEditor(typeof(UserRow))]
        [DisplayName("Assigned To")]
        public Int32 AssignedId { get; set; }
    }
}