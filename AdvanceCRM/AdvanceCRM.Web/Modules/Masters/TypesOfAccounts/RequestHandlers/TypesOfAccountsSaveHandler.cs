using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.TypesOfAccountsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.TypesOfAccountsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfAccountsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfAccountsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfAccountsSaveHandler
    {
        public TypesOfAccountsSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}