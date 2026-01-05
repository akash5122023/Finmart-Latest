using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = AdvanceCRM.Masters.BusinessDetailsRow;

namespace AdvanceCRM.Masters
{
    public interface IBusinessDetailsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BusinessDetailsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBusinessDetailsDeleteHandler
    {
        public BusinessDetailsDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}