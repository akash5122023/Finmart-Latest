namespace AdvanceCRM.Masters {
    export interface BusinessDetailsForm {
        BusinessDetailType: Serenity.StringEditor;
    }

    export class BusinessDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.BusinessDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!BusinessDetailsForm.init)  {
                BusinessDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(BusinessDetailsForm, [
                    'BusinessDetailType', w0
                ]);
            }
        }
    }
}
