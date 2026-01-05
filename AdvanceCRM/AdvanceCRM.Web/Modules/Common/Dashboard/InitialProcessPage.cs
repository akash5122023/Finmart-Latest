
namespace AdvanceCRM.Common.Pages
{
    
    using Administration;
    using AdvanceCRM.Enquiry;
    using AdvanceCRM.Common;
    using AdvanceCRM.Common.Calendar;   
    using AdvanceCRM.Operations;
    using AdvanceCRM.FinmartInsideSales;    
    using AdvanceCRM.Web.Helpers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Caching.Memory;
    using Microsoft.Extensions.Logging;
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using System.Linq;

    [Route("/InitialProcess")]
    public class InitialProcessController : Controller
    {
        private readonly ISqlConnections _connections;
        private readonly IMemoryCache _cache;
        private readonly ILogger<CalendarController> _logger;
        private readonly IRequestContext Context;

        public InitialProcessController(ISqlConnections connections, IRequestContext context, IMemoryCache cache, ILogger<CalendarController> logger)
        {
            _connections = connections;
            _cache = cache;
            _logger = logger;
            Context = context ?? throw new ArgumentNullException(nameof(context));

        }
        [Authorize, HttpGet]
        public IActionResult Index()
        {
            var cachedModel = LocalCache.GetLocalStoreOnly("InitialProcessPageModel", TimeSpan.FromSeconds(1),
                UserRow.Fields.GenerationKey, () =>
                {
                    var model = new InitialProcessPageModel();

                    var e = EnquiryRow.Fields;                    
                    var misinitialprocess = MisInitialProcessRow.Fields;
                    //var misloginprocess = MisLogInProcessRow.Fields;
                    //var misdisbursementprocess = MisDisbursementProcessRow.Fields;

                    var user = (UserDefinition)Context.User.ToUserDefinition();

                    using (var connection = _connections.NewFor<EnquiryRow>())
                    {
                       model.OpenMISInitialProcess = connection.Count<MisInitialProcessRow>(misinitialprocess.AssignedId == user.UserId);

                        //MIS INSIDE SALES
                        //var INSIDESALESLoanAmtList = connection.List<MisInitialProcessRow>(f => f
                        // .SelectTableFields()
                        // .Select(misinitialprocess.Id)
                        // .Where(misinitialprocess.AssignedId == user.UserId)
                        //);
                    }
                    return model;
                });

            return View(MVC.Views.Common.Dashboard.InitialProcessIndex, cachedModel);
        }
    }
}
