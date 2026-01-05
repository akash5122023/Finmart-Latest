namespace AdvanceCRM.Masters {
    export interface LogInLoanStatusForm {
        LogInLoanStatusName: Serenity.StringEditor;
    }

    export class LogInLoanStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.LogInLoanStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LogInLoanStatusForm.init)  {
                LogInLoanStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(LogInLoanStatusForm, [
                    'LogInLoanStatusName', w0
                ]);
            }
        }
    }
}
