using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Operations.MisInitialProcessRow>;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessRetrieveHandler
    {
        public MisInitialProcessRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            // Ensure all expression fields from joined tables are included
            var f = MyRow.Fields;
            query.Select(f.ContactsPhone);
            query.Select(f.ContactsEmail);
            query.Select(f.ContactsName);
            query.Select(f.ContactsAddress);
            query.Select(f.ContactsWhatsapp);
            query.Select(f.ContactsContactType);
            query.Select(f.ContactsCustomerType);
            query.Select(f.ContactPersonName);
            query.Select(f.ContactPersonPhone);
            query.Select(f.ContactPersonEmail);
            query.Select(f.ContactPersonAddress);
            query.Select(f.ContactPersonWhatsapp);
            query.Select(f.ContactPersonProject);
            query.Select(f.SourceName);
            query.Select(f.LeadStageName);
            query.Select(f.ProductProductTypeName);
            query.Select(f.BankNameBankNames);
            query.Select(f.OwnerUsername);
            query.Select(f.AssignedUsername);
        }
    }
}