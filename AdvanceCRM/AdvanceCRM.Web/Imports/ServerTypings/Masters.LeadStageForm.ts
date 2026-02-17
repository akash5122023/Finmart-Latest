namespace AdvanceCRM.Masters {
    export interface LeadStageForm {
        LeadStageName: Serenity.StringEditor;
    }

    export class LeadStageForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.LeadStage';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!LeadStageForm.init)  {
                LeadStageForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(LeadStageForm, [
                    'LeadStageName', w0
                ]);
            }
        }
    }
}
