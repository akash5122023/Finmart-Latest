
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

    [Route("/LoginProcess")]
    public class LoginProcessController : Controller
    {
        private readonly ISqlConnections _connections;
        private readonly IMemoryCache _cache;
        private readonly ILogger<CalendarController> _logger;
        private readonly IRequestContext Context;

        public LoginProcessController(ISqlConnections connections, IRequestContext context, IMemoryCache cache, ILogger<CalendarController> logger)
        {
            _connections = connections;
            _cache = cache;
            _logger = logger;
            Context = context ?? throw new ArgumentNullException(nameof(context));

        }
        [Authorize, HttpGet]
        public IActionResult Index()
        {
            var cachedModel = LocalCache.GetLocalStoreOnly("LoginProcessPageModel", TimeSpan.FromSeconds(1),
                UserRow.Fields.GenerationKey, () =>
                {
                    var model = new LoginProcessPageModel();

                    var e = EnquiryRow.Fields;                    
                    
                    var misloginprocess = MisLogInProcessRow.Fields;
                    //var misdisbursementprocess = MisDisbursementProcessRow.Fields;

                    var user = (UserDefinition)Context.User.ToUserDefinition();

                    using (var connection = _connections.NewFor<EnquiryRow>())
                    {
                       model.OpenMISLoginProcess = connection.Count<MisLogInProcessRow>(misloginprocess.AssignedId == user.UserId);
                    }
                    return model;
                });

            return View(MVC.Views.Common.Dashboard.LogInProcessIndex, cachedModel);
        }
    }
}
