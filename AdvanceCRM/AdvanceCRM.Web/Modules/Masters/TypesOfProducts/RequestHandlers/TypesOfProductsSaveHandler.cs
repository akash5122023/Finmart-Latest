using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.TypesOfProductsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.TypesOfProductsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfProductsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfProductsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfProductsSaveHandler
    {
        public TypesOfProductsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}