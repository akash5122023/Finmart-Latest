using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.RrSourceRow;

namespace AdvanceCRM.Masters
{
    public interface IRrSourceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RrSourceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRrSourceDeleteHandler
    {
        public RrSourceDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}