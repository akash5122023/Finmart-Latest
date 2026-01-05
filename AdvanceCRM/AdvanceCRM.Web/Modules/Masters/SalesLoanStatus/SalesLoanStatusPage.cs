using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(SalesLoanStatusRow))]
    public class SalesLoanStatusController : Controller
    {
        [Route("Masters/SalesLoanStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/SalesLoanStatus/SalesLoanStatusIndex.cshtml");
        }
    }
}