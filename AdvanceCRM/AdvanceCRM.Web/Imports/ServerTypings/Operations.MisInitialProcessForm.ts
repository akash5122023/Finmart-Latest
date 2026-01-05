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
        SourceName: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        FirmName: Serenity.StringEditor;
        ProductId: Serenity.LookupEditor;
        Requirement: Serenity.TextAreaEditor;
        FileReceivedDateTime: Serenity.DateEditor;
        QueriesGivenTime: Serenity.DateEditor;
        FileCompletionDateTime: Serenity.DateEditor;
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
                var w4 = s.DateEditor;

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
                    'SourceName', w2,
                    'CustomerName', w2,
                    'FirmName', w2,
                    'ProductId', w0,
                    'Requirement', w3,
                    'FileReceivedDateTime', w4,
                    'QueriesGivenTime', w4,
                    'FileCompletionDateTime', w4,
                    'AdditionalInformation', w3,
                    'OwnerId', w0,
                    'AssignedId', w0
                ]);
            }
        }
    }
}
