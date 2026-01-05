using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(MonthsInYearRow))]
    public class MonthsInYearController : Controller
    {
        [Route("Masters/MonthsInYear")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/MonthsInYear/MonthsInYearIndex.cshtml");
        }
    }
}