namespace AdvanceCRM.Operations {
    export interface MisLogInProcessForm {
        ContactPersonInTeam: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        MonthId: Serenity.LookupEditor;
        FileReceivedDateTime: Serenity.DateEditor;
        SourceName: Serenity.StringEditor;
        BankNameId: Serenity.LookupEditor;
        ProductId: Serenity.LookupEditor;
        CustomerName: Serenity.StringEditor;
        FirmName: Serenity.StringEditor;
        ContactNumber: Serenity.StringEditor;
        PrimeEmergingId: Serenity.LookupEditor;
        Location: Serenity.StringEditor;
        InhouseBankId: Serenity.LookupEditor;
        LogInLoanStatusId: Serenity.LookupEditor;
        Remark: Serenity.TextAreaEditor;
        AdditionalInformation: Serenity.TextAreaEditor;
        SystemLoginDate: Serenity.DateEditor;
        UnderwritingDate: Serenity.DateEditor;
        SalesManager: Serenity.StringEditor;
        NatureOfBusinessProfile: Serenity.StringEditor;
        ToPreviousYear: Serenity.StringEditor;
        ToLatestYear: Serenity.StringEditor;
        DisbursementDate: Serenity.DateEditor;
        LoanAccountNumber: Serenity.StringEditor;
        OwnerId: Serenity.LookupEditor;
        AssignedId: Serenity.LookupEditor;
    }

    export class MisLogInProcessForm extends Serenity.PrefixedContext {
        static formKey = 'Operations.MisLogInProcess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MisLogInProcessForm.init)  {
                MisLogInProcessForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DateEditor;
                var w4 = s.TextAreaEditor;

                Q.initFormType(MisLogInProcessForm, [
                    'ContactPersonInTeam', w0,
                    'Year', w1,
                    'MonthId', w2,
                    'FileReceivedDateTime', w3,
                    'SourceName', w0,
                    'BankNameId', w2,
                    'ProductId', w2,
                    'CustomerName', w0,
                    'FirmName', w0,
                    'ContactNumber', w0,
                    'PrimeEmergingId', w2,
                    'Location', w0,
                    'InhouseBankId', w2,
                    'LogInLoanStatusId', w2,
                    'Remark', w4,
                    'AdditionalInformation', w4,
                    'SystemLoginDate', w3,
                    'UnderwritingDate', w3,
                    'SalesManager', w0,
                    'NatureOfBusinessProfile', w0,
                    'ToPreviousYear', w0,
                    'ToLatestYear', w0,
                    'DisbursementDate', w3,
                    'LoanAccountNumber', w0,
                    'OwnerId', w2,
                    'AssignedId', w2
                ]);
            }
        }
    }
}
