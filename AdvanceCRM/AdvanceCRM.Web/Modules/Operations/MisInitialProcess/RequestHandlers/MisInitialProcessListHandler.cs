using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using AdvanceCRM.Administration;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<AdvanceCRM.Operations.MisInitialProcessRow>;
using MyRow = AdvanceCRM.Operations.MisInitialProcessRow;

namespace AdvanceCRM.Operations
{
    public interface IMisInitialProcessListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MisInitialProcessListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMisInitialProcessListHandler
    {
        public MisInitialProcessListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void ApplyFilters(SqlQuery query)
        {
            base.ApplyFilters(query);

            var user = (UserDefinition)Authorization.UserDefinition;
            if (user != null && !Authorization.HasPermission("Administration:Security"))
            {
                var fld = MyRow.Fields;
                // User can see records where they are either the Owner or Assigned user
                query.Where(new Criteria(fld.OwnerId) == user.UserId | 
                           new Criteria(fld.AssignedId) == user.UserId);
            }
        }
    }
}
