namespace AdvanceCRM.Masters {
    export interface RrSourceForm {
        SourceName: Serenity.StringEditor;
    }

    export class RrSourceForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.RrSource';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!RrSourceForm.init)  {
                RrSourceForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(RrSourceForm, [
                    'SourceName', w0
                ]);
            }
        }
    }
}
