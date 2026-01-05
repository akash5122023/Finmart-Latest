using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.TypesOfCompaniesRow>;
using MyRow = AdvanceCRM.Masters.TypesOfCompaniesRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfCompaniesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfCompaniesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfCompaniesListHandler
    {
        public TypesOfCompaniesListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}