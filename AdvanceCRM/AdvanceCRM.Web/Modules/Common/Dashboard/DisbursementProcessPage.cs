
namespace AdvanceCRM.Common.Pages
{
    
    using Administration;
    using AdvanceCRM.Common;
    using AdvanceCRM.Common.Calendar;   
    using AdvanceCRM.Enquiry;
    using AdvanceCRM.Operations;
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
    using static MVC.Views.Operations;

    [Route("/DisbursementProcess")]
    public class DisbursementProcessController : Controller
    {
        private readonly ISqlConnections _connections;
        private readonly IMemoryCache _cache;
        private readonly ILogger<CalendarController> _logger;
        private readonly IRequestContext Context;

        public DisbursementProcessController(ISqlConnections connections, IRequestContext context, IMemoryCache cache, ILogger<CalendarController> logger)
        {
            _connections = connections;
            _cache = cache;
            _logger = logger;
            Context = context ?? throw new ArgumentNullException(nameof(context));

        }
        [Authorize, HttpGet]
        public IActionResult Index()
        {
            var cachedModel = LocalCache.GetLocalStoreOnly("DisbursementProcessPageModel", TimeSpan.FromSeconds(1),
                UserRow.Fields.GenerationKey, () =>
                {
                    var model = new DisbursementProcessPageModel();

                    var e = EnquiryRow.Fields;                    
                    
                    var misdisbursementprocess = MisDisbursementProcessRow.Fields;

                    var user = (UserDefinition)Context.User.ToUserDefinition();

                    using (var connection = _connections.NewFor<EnquiryRow>())
                    {
                       model.OpenMISDisbursementProcess = connection.Count<MisDisbursementProcessRow>(misdisbursementprocess.AssignedId == user.UserId);

                        
                        
                    }
                    return model;
                });

            return View(MVC.Views.Common.Dashboard.DisbursementProcessIndex, cachedModel);
        }
    }
}
