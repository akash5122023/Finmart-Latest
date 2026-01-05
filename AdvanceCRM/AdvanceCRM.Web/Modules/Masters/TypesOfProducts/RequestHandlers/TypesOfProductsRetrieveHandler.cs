using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.TypesOfProductsRow>;
using MyRow = AdvanceCRM.Masters.TypesOfProductsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfProductsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfProductsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfProductsRetrieveHandler
    {
        public TypesOfProductsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}