namespace AdvanceCRM.Operations {
    export interface MisDisbursementProcessForm {
        ContactPersonInTeam: Serenity.StringEditor;
        Year: Serenity.IntegerEditor;
        MonthId: Serenity.LookupEditor;
        BankNameId: Serenity.LookupEditor;
        RRSourceId: Serenity.LookupEditor;
        CustomerName: Serenity.StringEditor;
        BankSourceOrCompanyName: Serenity.StringEditor;
        CibilScore: Serenity.IntegerEditor;
        LeadStageId: Serenity.LookupEditor;
        CustomerApprovalId: Serenity.LookupEditor;
        Amount: Serenity.DecimalEditor;
        NetAmt: Serenity.DecimalEditor;
        MisDisbursementStatusId: Serenity.LookupEditor;
        AdvanceEmi: Serenity.StringEditor;
        SubInsurancePf: Serenity.StringEditor;
        ProductId: Serenity.LookupEditor;
        PrimeEmergingId: Serenity.LookupEditor;
        Location: Serenity.StringEditor;
        MisDirectIndirectId: Serenity.LookupEditor;
        EmployeeName: Serenity.StringEditor;
        LoanAccountNumber: Serenity.StringEditor;
        ConfirmationMailTakenOrNot: Serenity.BooleanEditor;
        AgreementSigningPersonName: Serenity.StringEditor;
        AdditionalInformation: Serenity.TextAreaEditor;
        OwnerId: Serenity.LookupEditor;
    }

    export class MisDisbursementProcessForm extends Serenity.PrefixedContext {
        static formKey = 'Operations.MisDisbursementProcess';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MisDisbursementProcessForm.init)  {
                MisDisbursementProcessForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.BooleanEditor;
                var w5 = s.TextAreaEditor;

                Q.initFormType(MisDisbursementProcessForm, [
                    'ContactPersonInTeam', w0,
                    'Year', w1,
                    'MonthId', w2,
                    'BankNameId', w2,
                    'RRSourceId', w2,
                    'CustomerName', w0,
                    'BankSourceOrCompanyName', w0,
                    'CibilScore', w1,
                    'LeadStageId', w2,
                    'CustomerApprovalId', w2,
                    'Amount', w3,
                    'NetAmt', w3,
                    'MisDisbursementStatusId', w2,
                    'AdvanceEmi', w0,
                    'SubInsurancePf', w0,
                    'ProductId', w2,
                    'PrimeEmergingId', w2,
                    'Location', w0,
                    'MisDirectIndirectId', w2,
                    'EmployeeName', w0,
                    'LoanAccountNumber', w0,
                    'ConfirmationMailTakenOrNot', w4,
                    'AgreementSigningPersonName', w0,
                    'AdditionalInformation', w5,
                    'OwnerId', w2
                ]);
            }
        }
    }
}
