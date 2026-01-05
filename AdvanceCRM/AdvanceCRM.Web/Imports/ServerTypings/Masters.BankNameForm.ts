namespace AdvanceCRM.Masters {
    export interface BankNameForm {
        BankNames: Serenity.StringEditor;
    }

    export class BankNameForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.BankName';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BankNameForm.init)  {
                BankNameForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(BankNameForm, [
                    'BankNames', w0
                ]);
            }
        }
    }
}
