namespace AdvanceCRM.Operations {
    export interface MisInitialProcessForm {
        CustomerType: Serenity.EnumEditor;
        ContactsId: Serenity.LookupEditor;
        CustomerName: Serenity.StringEditor;
        FirmName: Serenity.StringEditor;
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
                var w0 = s.EnumEditor;
                var w1 = s.LookupEditor;
                var w2 = s.StringEditor;
                var w3 = s.IntegerEditor;
                var w4 = s.TextAreaEditor;
                var w5 = s.DecimalEditor;
                var w6 = s.DateTimeEditor;

                Q.initFormType(MisInitialProcessForm, [
                    'CustomerType', w0,
                    'ContactsId', w1,
                    'CustomerName', w2,
                    'FirmName', w2,
                    'ContactsContactType', w3,
                    'ContactsName', w2,
                    'ContactsEmail', w2,
                    'ContactsPhone', w2,
                    'ContactsWhatsapp', w2,
                    'ContactsAddress', w4,
                    'ContactPersonId', w1,
                    'ContactPersonName', w2,
                    'ContactPersonPhone', w2,
                    'ContactPersonWhatsapp', w2,
                    'ContactPersonProject', w2,
                    'ContactPersonAddress', w2,
                    'LeadStageId', w1,
                    'ProductId', w1,
                    'Requirement', w4,
                    'BankNameId', w1,
                    'LoanAmount', w5,
                    'FileReceivedDateTime', w6,
                    'QueriesGivenTime', w6,
                    'FileCompletionDateTime', w6,
                    'AdditionalInformation', w4,
                    'OwnerId', w1,
                    'AssignedId', w1
                ]);
            }
        }
    }
}
