using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.MisDirectIndirectRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDirectIndirectDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDirectIndirectDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMisDirectIndirectDeleteHandler
    {
        public MisDirectIndirectDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}