using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.TypesOfAccountsRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfAccountsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfAccountsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfAccountsDeleteHandler
    {
        public TypesOfAccountsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}