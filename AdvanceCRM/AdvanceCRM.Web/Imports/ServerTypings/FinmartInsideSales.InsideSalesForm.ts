namespace AdvanceCRM.FinmartInsideSales {
    export interface InsideSalesForm {
        MonthId: Serenity.LookupEditor;
        FileReceivedDateTime: Serenity.DateEditor;
        FirmName: Serenity.StringEditor;
        CompanyTypeId: Serenity.LookupEditor;
        ProfileOfTheLead: Serenity.StringEditor;
        ContactNumber: Serenity.StringEditor;
        CompanyMailId: Serenity.StringEditor;
        ProductId: Serenity.LookupEditor;
        NatureOfBusinessProfile: Serenity.StringEditor;
        BusinessVintage: Serenity.StringEditor;
        BusinessDetailId: Serenity.LookupEditor;
        AccountTypeId: Serenity.LookupEditor;
        SalesLoanStatusId: Serenity.LookupEditor;
        LoanAmount: Serenity.DecimalEditor;
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
                var w1 = s.DateEditor;
                var w2 = s.StringEditor;
                var w3 = s.DecimalEditor;
                var w4 = s.TextAreaEditor;

                Q.initFormType(InsideSalesForm, [
                    'MonthId', w0,
                    'FileReceivedDateTime', w1,
                    'FirmName', w2,
                    'CompanyTypeId', w0,
                    'ProfileOfTheLead', w2,
                    'ContactNumber', w2,
                    'CompanyMailId', w2,
                    'ProductId', w0,
                    'NatureOfBusinessProfile', w2,
                    'BusinessVintage', w2,
                    'BusinessDetailId', w0,
                    'AccountTypeId', w0,
                    'SalesLoanStatusId', w0,
                    'LoanAmount', w3,
                    'Remark', w4,
                    'AdditionalInformation', w4,
                    'StageOfTheCaseId', w0,
                    'OwnerId', w0,
                    'AssignedId', w0
                ]);
            }
        }
    }
}
