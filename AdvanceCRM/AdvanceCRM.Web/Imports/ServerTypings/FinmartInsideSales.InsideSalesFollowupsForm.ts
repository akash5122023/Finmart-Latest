namespace AdvanceCRM.FinmartInsideSales {
    export interface InsideSalesFollowupsForm {
        FollowupNote: Serenity.StringEditor;
        Details: Serenity.TextAreaEditor;
        FollowupDate: Serenity.DateTimeEditor;
        Status: Serenity.EnumEditor;
        RepresentativeId: Administration.UserEditor;
        ClosingDate: Serenity.DateTimeEditor;
        InsideSalesId: Serenity.IntegerEditor;
    }

    export class InsideSalesFollowupsForm extends Serenity.PrefixedContext {
        static formKey = 'FinmartInsideSales.InsideSalesFollowups';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InsideSalesFollowupsForm.init)  {
                InsideSalesFollowupsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.DateTimeEditor;
                var w3 = s.EnumEditor;
                var w4 = Administration.UserEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(InsideSalesFollowupsForm, [
                    'FollowupNote', w0,
                    'Details', w1,
                    'FollowupDate', w2,
                    'Status', w3,
                    'RepresentativeId', w4,
                    'ClosingDate', w2,
                    'InsideSalesId', w5
                ]);
            }
        }
    }
}
