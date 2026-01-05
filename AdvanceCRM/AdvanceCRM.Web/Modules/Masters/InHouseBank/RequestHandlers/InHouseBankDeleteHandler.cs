using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.InHouseBankRow;

namespace AdvanceCRM.Masters
{
    public interface IInHouseBankDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class InHouseBankDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInHouseBankDeleteHandler
    {
        public InHouseBankDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}