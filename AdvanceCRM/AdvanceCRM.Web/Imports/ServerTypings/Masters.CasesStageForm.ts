namespace AdvanceCRM.Masters {
    export interface CasesStageForm {
        CasesStageName: Serenity.StringEditor;
    }

    export class CasesStageForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.CasesStage';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CasesStageForm.init)  {
                CasesStageForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CasesStageForm, [
                    'CasesStageName', w0
                ]);
            }
        }
    }
}
