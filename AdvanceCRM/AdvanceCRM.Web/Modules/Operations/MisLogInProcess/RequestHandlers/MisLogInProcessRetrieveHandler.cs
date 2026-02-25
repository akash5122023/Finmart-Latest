using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Operations.MisLogInProcessRow>;
using MyRow = AdvanceCRM.Operations.MisLogInProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisLogInProcessRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisLogInProcessRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisLogInProcessRetrieveHandler
    {
        public MisLogInProcessRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            // Ensure all expression fields from joined tables are included
            var f = MyRow.Fields;
            query.Select(f.SourceName);
            query.Select(f.LeadStageName);
            query.Select(f.ProductProductTypeName);
            query.Select(f.BankNameBankNames);
            query.Select(f.PrimeEmergingPrimeEmergingName);
            query.Select(f.InhouseBankInHouseBankType);
            query.Select(f.LogInLoanStatusLogInLoanStatusName);
            query.Select(f.OwnerUsername);
            query.Select(f.AssignedUsername);
            query.Select(f.MonthMonthsName);
        }
    }
}