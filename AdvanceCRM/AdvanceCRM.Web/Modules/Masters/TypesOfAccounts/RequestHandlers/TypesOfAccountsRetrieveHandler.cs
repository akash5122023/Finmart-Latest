using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.TypesOfAccountsRow>;
using MyRow = AdvanceCRM.Masters.TypesOfAccountsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfAccountsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfAccountsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfAccountsRetrieveHandler
    {
        public TypesOfAccountsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}