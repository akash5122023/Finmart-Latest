namespace AdvanceCRM.Masters {
    export interface MonthsInYearForm {
        MonthsName: Serenity.StringEditor;
    }

    export class MonthsInYearForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.MonthsInYear';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MonthsInYearForm.init)  {
                MonthsInYearForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MonthsInYearForm, [
                    'MonthsName', w0
                ]);
            }
        }
    }
}
