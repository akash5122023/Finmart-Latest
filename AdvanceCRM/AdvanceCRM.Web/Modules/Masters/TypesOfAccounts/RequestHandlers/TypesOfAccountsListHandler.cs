using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.TypesOfAccountsRow>;
using MyRow = AdvanceCRM.Masters.TypesOfAccountsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfAccountsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfAccountsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfAccountsListHandler
    {
        public TypesOfAccountsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}