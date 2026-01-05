using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.BusinessDetailsRow>;
using MyRow = AdvanceCRM.Masters.BusinessDetailsRow;

namespace AdvanceCRM.Masters
{
    public interface IBusinessDetailsListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessDetailsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessDetailsListHandler
    {
        public BusinessDetailsListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}