using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.TypesOfCompaniesRow>;
using MyRow = AdvanceCRM.Masters.TypesOfCompaniesRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfCompaniesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfCompaniesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfCompaniesRetrieveHandler
    {
        public TypesOfCompaniesRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}