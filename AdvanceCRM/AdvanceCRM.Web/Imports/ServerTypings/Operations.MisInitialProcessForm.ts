namespace AdvanceCRM.Operations {
    export interface MisInitialProcessForm {
        RRSourceId: Serenity.LookupEditor;
        CustomerName: Serenity.StringEditor;
        FirmName: Serenity.StringEditor;
        LeadStageId: Serenity.LookupEditor;
        ProductId: Serenity.LookupEditor;
        Requirement: Serenity.TextAreaEditor;
        BankNameId: Serenity.LookupEditor;
        LoanAmount: Serenity.DecimalEditor;
        FileReceivedDateTime: Serenity.DateTimeEditor;
        QueriesGivenTime: Serenity.DateTimeEditor;
        FileCompletionDateTime: Serenity.DateTimeEditor;
        AdditionalInformation: Serenity.TextAreaEditor;
        OwnerId: Serenity.LookupEditor;
        AssignedId: Serenity.LookupEditor;
    }

    export class MisInitialProcessForm extends Serenity.PrefixedContext {
        static formKey = 'Operations.MisInitialProcess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MisInitialProcessForm.init)  {
                MisInitialProcessForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.TextAreaEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.DateTimeEditor;

                Q.initFormType(MisInitialProcessForm, [
                    'RRSourceId', w0,
                    'CustomerName', w1,
                    'FirmName', w1,
                    'LeadStageId', w0,
                    'ProductId', w0,
                    'Requirement', w2,
                    'BankNameId', w0,
                    'LoanAmount', w3,
                    'FileReceivedDateTime', w4,
                    'QueriesGivenTime', w4,
                    'FileCompletionDateTime', w4,
                    'AdditionalInformation', w2,
                    'OwnerId', w0,
                    'AssignedId', w0
                ]);
            }
        }
    }
}
