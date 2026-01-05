using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.TypesOfCompaniesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.TypesOfCompaniesRow;

namespace AdvanceCRM.Masters
{
    public interface ITypesOfCompaniesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class TypesOfCompaniesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITypesOfCompaniesSaveHandler
    {
        public TypesOfCompaniesSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}