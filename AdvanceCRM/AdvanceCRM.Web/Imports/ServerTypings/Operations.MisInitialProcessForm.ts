namespace AdvanceCRM.Operations {
    export interface MisInitialProcessForm {
        ContactsId: Serenity.LookupEditor;
        ContactsContactType: Serenity.IntegerEditor;
        ContactsName: Serenity.StringEditor;
        ContactsEmail: Serenity.StringEditor;
        ContactsPhone: Serenity.StringEditor;
        ContactsWhatsapp: Serenity.StringEditor;
        ContactsAddress: Serenity.TextAreaEditor;
        ContactPersonId: Serenity.LookupEditor;
        ContactPersonName: Serenity.StringEditor;
        ContactPersonPhone: Serenity.StringEditor;
        ContactPersonWhatsapp: Serenity.StringEditor;
        ContactPersonProject: Serenity.StringEditor;
        ContactPersonAddress: Serenity.StringEditor;
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
                var w1 = s.IntegerEditor;
                var w2 = s.StringEditor;
                var w3 = s.TextAreaEditor;
                var w4 = s.DecimalEditor;
                var w5 = s.DateTimeEditor;

                Q.initFormType(MisInitialProcessForm, [
                    'ContactsId', w0,
                    'ContactsContactType', w1,
                    'ContactsName', w2,
                    'ContactsEmail', w2,
                    'ContactsPhone', w2,
                    'ContactsWhatsapp', w2,
                    'ContactsAddress', w3,
                    'ContactPersonId', w0,
                    'ContactPersonName', w2,
                    'ContactPersonPhone', w2,
                    'ContactPersonWhatsapp', w2,
                    'ContactPersonProject', w2,
                    'ContactPersonAddress', w2,
                    'RRSourceId', w0,
                    'CustomerName', w2,
                    'FirmName', w2,
                    'LeadStageId', w0,
                    'ProductId', w0,
                    'Requirement', w3,
                    'BankNameId', w0,
                    'LoanAmount', w4,
                    'FileReceivedDateTime', w5,
                    'QueriesGivenTime', w5,
                    'FileCompletionDateTime', w5,
                    'AdditionalInformation', w3,
                    'OwnerId', w0,
                    'AssignedId', w0
                ]);
            }
        }
    }
}
