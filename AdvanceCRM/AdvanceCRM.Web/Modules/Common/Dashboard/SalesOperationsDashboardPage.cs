
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
    using Serenity.Abstractions;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web;
    using System;
    using System.Data;
    using System.Linq;

    [Route("/SalesOperationsDashboard")]
    public class SalesOperationsDashboardController : Controller
    {
        private readonly ISqlConnections _connections;
        private readonly IMemoryCache _cache;
        private readonly ILogger<CalendarController> _logger;
        private readonly IRequestContext Context;
        private readonly IPermissionService _permissionService;

        public SalesOperationsDashboardController(ISqlConnections connections, IRequestContext context, IMemoryCache cache, ILogger<CalendarController> logger, IPermissionService permissionService)
        {
            _connections = connections;
            _cache = cache;
            _logger = logger;
            Context = context ?? throw new ArgumentNullException(nameof(context));
            _permissionService = permissionService;
        }

        [Authorize, HttpGet]
        public IActionResult Index()
        {
            var model = new SalesOperationsDashboardPageModel();

            // Check permissions for role-based visibility
            model.CanViewInsideSales = _permissionService.HasPermission("InsideSales:Read");
            model.CanViewInitialProcess = _permissionService.HasPermission("MisInitialProcess:Read");
            model.CanViewLoginProcess = _permissionService.HasPermission("MisLogInProcess:Read");
            model.CanViewDisbursementProcess = _permissionService.HasPermission("MisDisbursementProcess:Read");

            var e = EnquiryRow.Fields;
            var insidesales = InsideSalesRow.Fields;
            var misinitialprocess = MisInitialProcessRow.Fields;
            var misloginprocess = MisLogInProcessRow.Fields;
            var misdisbursementprocess = MisDisbursementProcessRow.Fields;

            var user = (UserDefinition)Context.User.ToUserDefinition();

            using (var connection = _connections.NewFor<EnquiryRow>())
            {
                // Only fetch data for sections user has permission to view
                if (model.CanViewInsideSales)
                {
                    model.OpenMISSales = connection.Count<InsideSalesRow>(insidesales.AssignedId == user.UserId);
                }

                if (model.CanViewInitialProcess)
                {
                    model.OpenMISInitialProcess = connection.Count<MisInitialProcessRow>(misinitialprocess.AssignedId == user.UserId);
                }

                if (model.CanViewLoginProcess)
                {
                    model.OpenMISLoginProcess = connection.Count<MisLogInProcessRow>(misloginprocess.AssignedId == user.UserId);
                }

                if (model.CanViewDisbursementProcess)
                {
                    model.OpenMISDisbursementProcess = connection.Count<MisDisbursementProcessRow>(misdisbursementprocess.AssignedId == user.UserId);
                }
            }

            return View(MVC.Views.Common.Dashboard.SalesOperationsDashboardIndex, model);
        }
    }
}
