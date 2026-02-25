using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.FinmartInsideSales.InsideSalesRow>;
using MyRow = AdvanceCRM.FinmartInsideSales.InsideSalesRow;

namespace AdvanceCRM.FinmartInsideSales
{
    public interface IInsideSalesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class InsideSalesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInsideSalesRetrieveHandler
    {
        public InsideSalesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            // Ensure all expression fields from joined tables are included
            var f = MyRow.Fields;
            query.Select(f.ContactsName);
            query.Select(f.ContactsPhone);
            query.Select(f.ContactsEmail);
            query.Select(f.ContactPersonName);
            query.Select(f.ContactPersonPhone);
            query.Select(f.MonthMonthsName);
            query.Select(f.ProductProductTypeName);
            query.Select(f.BusinessDetailBusinessDetailType);
            query.Select(f.CompanyTypeCompanyTypeName);
            query.Select(f.AccountTypeAccountTypeName);
            query.Select(f.SalesLoanStatusSalesLoanStatusName);
            query.Select(f.StageOfTheCaseCasesStageName);
            query.Select(f.OwnerUsername);
            query.Select(f.AssignedUsername);
        }
    }
}