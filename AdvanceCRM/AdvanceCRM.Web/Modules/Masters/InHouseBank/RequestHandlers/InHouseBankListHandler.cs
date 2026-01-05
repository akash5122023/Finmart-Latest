using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.InHouseBankRow>;
using MyRow = AdvanceCRM.Masters.InHouseBankRow;

namespace AdvanceCRM.Masters
{
    public interface IInHouseBankListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class InHouseBankListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInHouseBankListHandler
    {
        public InHouseBankListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}