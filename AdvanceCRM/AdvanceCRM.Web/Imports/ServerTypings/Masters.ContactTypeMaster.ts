namespace AdvanceCRM.Masters {
    export enum ContactTypeMaster {
        Customer = 1,
        Vendor = 2,
        ChannelPartner = 3
    }
    Serenity.Decorators.registerEnumType(ContactTypeMaster, 'AdvanceCRM.Masters.ContactTypeMaster', 'Masters.ContactType');
}
