using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.MisDisbursementStatusRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDisbursementStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDisbursementStatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMisDisbursementStatusDeleteHandler
    {
        public MisDisbursementStatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}