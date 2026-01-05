using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<AdvanceCRM.Masters.BusinessDetailsRow>;
using MyRow = AdvanceCRM.Masters.BusinessDetailsRow;

namespace AdvanceCRM.Masters
{
    public interface IBusinessDetailsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessDetailsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessDetailsRetrieveHandler
    {
        public BusinessDetailsRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}