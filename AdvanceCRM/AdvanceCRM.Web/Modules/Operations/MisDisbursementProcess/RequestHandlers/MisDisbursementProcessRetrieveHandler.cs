using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Operations.MisDisbursementProcessRow>;
using MyRow = AdvanceCRM.Operations.MisDisbursementProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisDisbursementProcessRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementProcessRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementProcessRetrieveHandler
    {
        public MisDisbursementProcessRetrieveHandler(IRequestContext context)
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
            query.Select(f.CustomerApprovalType);
            query.Select(f.ProductProductTypeName);
            query.Select(f.BankNameBankNames);
            query.Select(f.PrimeEmergingPrimeEmergingName);
            query.Select(f.InhouseBankInHouseBankType);
            query.Select(f.LogInLoanStatusLogInLoanStatusName);
            query.Select(f.MisDisbursementStatusMisDisbursementStatusType);
            query.Select(f.OwnerUsername);
            query.Select(f.AssignedUsername);
            query.Select(f.MonthMonthsName);
        }
    }
}