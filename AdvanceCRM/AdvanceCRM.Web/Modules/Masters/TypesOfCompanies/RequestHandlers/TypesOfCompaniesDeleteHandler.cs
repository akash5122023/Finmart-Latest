using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.TypesOfCompaniesRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfCompaniesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfCompaniesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfCompaniesDeleteHandler
    {
        public TypesOfCompaniesDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}