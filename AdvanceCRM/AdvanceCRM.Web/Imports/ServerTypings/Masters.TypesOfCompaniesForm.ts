namespace AdvanceCRM.Masters {
    export interface TypesOfCompaniesForm {
        CompanyTypeName: Serenity.StringEditor;
    }

    export class TypesOfCompaniesForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.TypesOfCompanies';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TypesOfCompaniesForm.init)  {
                TypesOfCompaniesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(TypesOfCompaniesForm, [
                    'CompanyTypeName', w0
                ]);
            }
        }
    }
}
