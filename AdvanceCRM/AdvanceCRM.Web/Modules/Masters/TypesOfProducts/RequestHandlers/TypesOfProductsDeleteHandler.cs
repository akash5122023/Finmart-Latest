using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.TypesOfProductsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfProductsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfProductsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfProductsDeleteHandler
    {
        public TypesOfProductsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}