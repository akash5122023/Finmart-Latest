using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Masters.MisDirectIndirectRow>;
using MyRow = AdvanceCRM.Masters.MisDirectIndirectRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDirectIndirectListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDirectIndirectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisDirectIndirectListHandler
    {
        public MisDirectIndirectListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}