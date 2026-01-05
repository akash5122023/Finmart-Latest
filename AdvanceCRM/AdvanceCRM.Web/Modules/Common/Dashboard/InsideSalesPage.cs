
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

    [Route("/InsideSales")]
    public class InsideSalesController : Controller
    {
        private readonly ISqlConnections _connections;
        private readonly IMemoryCache _cache;
        private readonly ILogger<CalendarController> _logger;
        private readonly IRequestContext Context;

        public InsideSalesController(ISqlConnections connections, IRequestContext context, IMemoryCache cache, ILogger<CalendarController> logger)
        {
            _connections = connections;
            _cache = cache;
            _logger = logger;
            Context = context ?? throw new ArgumentNullException(nameof(context));

        }
        [Authorize, HttpGet]
        public IActionResult Index()
        {
            var cachedModel = LocalCache.GetLocalStoreOnly("InsideSalesPageModel", TimeSpan.FromSeconds(1),
                UserRow.Fields.GenerationKey, () =>
                {
                    var model = new InsideSalesPageModel();

                    var e = EnquiryRow.Fields;                    
                    var insidesales = InsideSalesRow.Fields;                   

                    var user = (UserDefinition)Context.User.ToUserDefinition();

                    using (var connection = _connections.NewFor<EnquiryRow>())
                    {
                       model.OpenMISSales = connection.Count<InsideSalesRow>(insidesales.AssignedId == user.UserId);                       
                    }
                    return model;
                });

            return View(MVC.Views.Common.Dashboard.InsideSalesIndex, cachedModel);
        }
    }
}
