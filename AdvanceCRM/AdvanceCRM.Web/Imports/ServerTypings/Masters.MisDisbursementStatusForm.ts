namespace AdvanceCRM.Masters {
    export interface MisDisbursementStatusForm {
        MisDisbursementStatusType: Serenity.StringEditor;
    }

    export class MisDisbursementStatusForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.MisDisbursementStatus';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MisDisbursementStatusForm.init)  {
                MisDisbursementStatusForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MisDisbursementStatusForm, [
                    'MisDisbursementStatusType', w0
                ]);
            }
        }
    }
}
