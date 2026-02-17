namespace AdvanceCRM.Masters {
    export interface CustomerApprovalForm {
        CustomerApprovalType: Serenity.StringEditor;
    }

    export class CustomerApprovalForm extends Serenity.PrefixedContext {
        static formKey = 'Masters.CustomerApproval';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomerApprovalForm.init)  {
                CustomerApprovalForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(CustomerApprovalForm, [
                    'CustomerApprovalType', w0
                ]);
            }
        }
    }
}
