namespace AdvanceCRM.Operations {
    export interface MisInitialProcessForm {
        CustomerType: Serenity.EnumEditor;
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
                var w0 = s.EnumEditor;
                var w1 = s.LookupEditor;
                var w2 = s.IntegerEditor;
                var w3 = s.StringEditor;
                var w4 = s.TextAreaEditor;
                var w5 = s.DecimalEditor;
                var w6 = s.DateTimeEditor;

                Q.initFormType(MisInitialProcessForm, [
                    'CustomerType', w0,
                    'ContactsId', w1,
                    'ContactsContactType', w2,
                    'ContactsName', w3,
                    'ContactsEmail', w3,
                    'ContactsPhone', w3,
                    'ContactsWhatsapp', w3,
                    'ContactsAddress', w4,
                    'ContactPersonId', w1,
                    'ContactPersonName', w3,
                    'ContactPersonPhone', w3,
                    'ContactPersonWhatsapp', w3,
                    'ContactPersonProject', w3,
                    'ContactPersonAddress', w3,
                    'RRSourceId', w1,
                    'CustomerName', w3,
                    'FirmName', w3,
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
