using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(LogInLoanStatusRow))]
    public class LogInLoanStatusController : Controller
    {
        [Route("Masters/LogInLoanStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/LogInLoanStatus/LogInLoanStatusIndex.cshtml");
        }
    }
}