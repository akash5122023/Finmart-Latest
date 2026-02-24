using AdvanceCRM.Masters;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace AdvanceCRM.Contacts.Lookups
{
    [LookupScript("Contacts.ContactsChannelPartnerLookup", Permission = "*")]
    public class ContactsChannelPartnerLookup : RowLookupScript<ContactsRow>
    {
        public ContactsChannelPartnerLookup(ISqlConnections connections)
            : base(connections)
        {
            IdField = ContactsRow.Fields.Id.PropertyName;
            TextField = ContactsRow.Fields.Name.PropertyName;
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            var f = ContactsRow.Fields;

            query.Where(
                f.CustomerType == (int)ContactTypeMaster.ChannelPartner
            );
        }
    }
}
