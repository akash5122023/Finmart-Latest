namespace AdvanceCRM.Masters {
    export interface TypesOfAccountsForm {
        AccountTypeName: Serenity.StringEditor;
    }

    export class TypesOfAccountsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.TypesOfAccounts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TypesOfAccountsForm.init)  {
                TypesOfAccountsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(TypesOfAccountsForm, [
                    'AccountTypeName', w0
                ]);
            }
        }
    }
}
