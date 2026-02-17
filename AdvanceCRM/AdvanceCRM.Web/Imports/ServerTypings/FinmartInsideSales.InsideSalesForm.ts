namespace AdvanceCRM.FinmartInsideSales {
    export interface InsideSalesForm {
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
        MonthId: Serenity.LookupEditor;
        FileReceivedDateTime: Serenity.DateTimeEditor;
        CompanyTypeId: Serenity.LookupEditor;
        ProfileOfTheLead: Serenity.StringEditor;
        CompanyMailId: Serenity.StringEditor;
        ProductId: Serenity.LookupEditor;
        NatureOfBusinessProfile: Serenity.StringEditor;
        BusinessVintage: Serenity.StringEditor;
        BusinessDetailId: Serenity.LookupEditor;
        AccountTypeId: Serenity.LookupEditor;
        SalesLoanStatusId: Serenity.LookupEditor;
        LoanAmount: LoanAmountEditor;
        Remark: Serenity.TextAreaEditor;
        AdditionalInformation: Serenity.TextAreaEditor;
        StageOfTheCaseId: Serenity.LookupEditor;
        OwnerId: Serenity.LookupEditor;
        AssignedId: Serenity.LookupEditor;
    }

    export class InsideSalesForm extends Serenity.PrefixedContext {
        static formKey = 'FinmartInsideSales.InsideSales';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!InsideSalesForm.init)  {
                InsideSalesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.StringEditor;
                var w3 = s.TextAreaEditor;
                var w4 = s.DateTimeEditor;
                var w5 = LoanAmountEditor;

                Q.initFormType(InsideSalesForm, [
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
                    'MonthId', w0,
                    'FileReceivedDateTime', w4,
                    'CompanyTypeId', w0,
                    'ProfileOfTheLead', w2,
                    'CompanyMailId', w2,
                    'ProductId', w0,
                    'NatureOfBusinessProfile', w2,
                    'BusinessVintage', w2,
                    'BusinessDetailId', w0,
                    'AccountTypeId', w0,
                    'SalesLoanStatusId', w0,
                    'LoanAmount', w5,
                    'Remark', w3,
                    'AdditionalInformation', w3,
                    'StageOfTheCaseId', w0,
                    'OwnerId', w0,
                    'AssignedId', w0
                ]);
            }
        }
    }
}
