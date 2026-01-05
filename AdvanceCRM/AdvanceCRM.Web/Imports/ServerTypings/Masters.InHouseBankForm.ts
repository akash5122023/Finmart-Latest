namespace AdvanceCRM.Masters {
    export interface InHouseBankForm {
        InHouseBankType: Serenity.StringEditor;
    }

    export class InHouseBankForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.InHouseBank';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InHouseBankForm.init)  {
                InHouseBankForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(InHouseBankForm, [
                    'InHouseBankType', w0
                ]);
            }
        }
    }
}
