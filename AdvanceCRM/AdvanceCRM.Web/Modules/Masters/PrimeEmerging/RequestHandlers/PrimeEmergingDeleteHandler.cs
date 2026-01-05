using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.PrimeEmergingRow;

namespace AdvanceCRM.Masters
{
    public interface IPrimeEmergingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PrimeEmergingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPrimeEmergingDeleteHandler
    {
        public PrimeEmergingDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}