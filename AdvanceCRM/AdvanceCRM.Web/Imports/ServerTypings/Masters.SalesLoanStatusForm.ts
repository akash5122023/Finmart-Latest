namespace AdvanceCRM.Masters {
    export interface SalesLoanStatusForm {
        SalesLoanStatusName: Serenity.StringEditor;
    }

    export class SalesLoanStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.SalesLoanStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SalesLoanStatusForm.init)  {
                SalesLoanStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(SalesLoanStatusForm, [
                    'SalesLoanStatusName', w0
                ]);
            }
        }
    }
}
