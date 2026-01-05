namespace AdvanceCRM.Masters {
    export interface MisDirectIndirectForm {
        MisDirectIndirectType: Serenity.StringEditor;
    }

    export class MisDirectIndirectForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.MisDirectIndirect';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MisDirectIndirectForm.init)  {
                MisDirectIndirectForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(MisDirectIndirectForm, [
                    'MisDirectIndirectType', w0
                ]);
            }
        }
    }
}
