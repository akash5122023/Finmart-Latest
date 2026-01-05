using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.TypesOfProductsRow>;
using MyRow = AdvanceCRM.Masters.TypesOfProductsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfProductsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfProductsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfProductsListHandler
    {
        public TypesOfProductsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}