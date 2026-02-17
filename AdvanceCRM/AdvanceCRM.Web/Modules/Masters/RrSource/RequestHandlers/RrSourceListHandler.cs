using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.RrSourceRow>;
using MyRow = AdvanceCRM.Masters.RrSourceRow;

namespace AdvanceCRM.Masters
{
    public interface IRrSourceListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class RrSourceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRrSourceListHandler
    {
        public RrSourceListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}