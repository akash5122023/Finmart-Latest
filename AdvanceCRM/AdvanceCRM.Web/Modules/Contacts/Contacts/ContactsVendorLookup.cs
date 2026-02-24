//using AdvanceCRM.Contacts.Entities;
using AdvanceCRM.Masters;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;
using Serenity.Web;

namespace AdvanceCRM.Contacts.Lookups
{
    [LookupScript("Contacts.VendorLookup", Permission = "*")]
    public class VendorLookup : RowLookupScript<ContactsRow>
    {
        public VendorLookup(ISqlConnections connections)
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
                f.CustomerType == (int)ContactTypeMaster.Vendor
            );
        }
    }
}
