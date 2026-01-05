namespace AdvanceCRM.Masters {
    export interface PrimeEmergingForm {
        PrimeEmergingName: Serenity.StringEditor;
    }

    export class PrimeEmergingForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.PrimeEmerging';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PrimeEmergingForm.init)  {
                PrimeEmergingForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(PrimeEmergingForm, [
                    'PrimeEmergingName', w0
                ]);
            }
        }
    }
}
