namespace AdvanceCRM.Masters {
    export interface TypesOfProductsForm {
        ProductTypeName: Serenity.StringEditor;
    }

    export class TypesOfProductsForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.TypesOfProducts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!TypesOfProductsForm.init)  {
                TypesOfProductsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(TypesOfProductsForm, [
                    'ProductTypeName', w0
                ]);
            }
        }
    }
}
