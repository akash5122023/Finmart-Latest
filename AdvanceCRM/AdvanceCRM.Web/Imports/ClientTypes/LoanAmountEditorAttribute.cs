using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AdvanceCRM
{
    public partial class LoanAmountEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "AdvanceCRM.LoanAmountEditor";

        public LoanAmountEditorAttribute()
            : base(Key)
        {
        }
    }
}
