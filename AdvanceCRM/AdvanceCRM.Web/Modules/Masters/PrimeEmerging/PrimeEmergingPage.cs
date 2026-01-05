using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(PrimeEmergingRow))]
    public class PrimeEmergingController : Controller
    {
        [Route("Masters/PrimeEmerging")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/PrimeEmerging/PrimeEmergingIndex.cshtml");
        }
    }
}