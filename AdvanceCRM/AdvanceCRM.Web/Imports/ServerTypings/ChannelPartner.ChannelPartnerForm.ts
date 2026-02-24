namespace AdvanceCRM.ChannelPartner {
    export interface ChannelPartnerForm {
        BankNameId: Serenity.LookupEditor;
        BankSalesManagerName: Serenity.StringEditor;
        ProductId: Serenity.LookupEditor;
        LoanAmount: Serenity.DecimalEditor;
        LoginDate: Serenity.DateTimeEditor;
        MisDisbursementStatusId: Serenity.LookupEditor;
        DisbursementDate: Serenity.DateTimeEditor;
        DisbursedAmount: Serenity.DecimalEditor;
        OwnerId: Serenity.LookupEditor;
    }

    export class ChannelPartnerForm extends Serenity.PrefixedContext {
        static formKey = 'ChannelPartner.ChannelPartner';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ChannelPartnerForm.init)  {
                ChannelPartnerForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.DecimalEditor;
                var w3 = s.DateTimeEditor;

                Q.initFormType(ChannelPartnerForm, [
                    'BankNameId', w0,
                    'BankSalesManagerName', w1,
                    'ProductId', w0,
                    'LoanAmount', w2,
                    'LoginDate', w3,
                    'MisDisbursementStatusId', w0,
                    'DisbursementDate', w3,
                    'DisbursedAmount', w2,
                    'OwnerId', w0
                ]);
            }
        }
    }
}
