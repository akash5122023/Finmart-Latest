namespace AdvanceCRM.ChannelPartner {
    export interface ChannelPartnerFollowupsForm {
        FollowupNote: Serenity.StringEditor;
        Details: Serenity.TextAreaEditor;
        FollowupDate: Serenity.DateTimeEditor;
        Status: Serenity.EnumEditor;
        RepresentativeId: Administration.UserEditor;
        ClosingDate: Serenity.DateTimeEditor;
        ChannelPartnerId: Serenity.IntegerEditor;
    }

    export class ChannelPartnerFollowupsForm extends Serenity.PrefixedContext {
        static formKey = 'ChannelPartner.ChannelPartnerFollowups';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ChannelPartnerFollowupsForm.init)  {
                ChannelPartnerFollowupsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.DateTimeEditor;
                var w3 = s.EnumEditor;
                var w4 = Administration.UserEditor;
                var w5 = s.IntegerEditor;

                Q.initFormType(ChannelPartnerFollowupsForm, [
                    'FollowupNote', w0,
                    'Details', w1,
                    'FollowupDate', w2,
                    'Status', w3,
                    'RepresentativeId', w4,
                    'ClosingDate', w2,
                    'ChannelPartnerId', w5
                ]);
            }
        }
    }
}
