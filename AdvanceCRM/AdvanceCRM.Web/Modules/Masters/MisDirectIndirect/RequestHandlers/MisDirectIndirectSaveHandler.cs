using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<AdvanceCRM.Masters.MisDirectIndirectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = AdvanceCRM.Masters.MisDirectIndirectRow;

namespace AdvanceCRM.Masters
{
    public interface IMisDirectIndirectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MisDirectIndirectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMisDirectIndirectSaveHandler
    {
        public MisDirectIndirectSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}