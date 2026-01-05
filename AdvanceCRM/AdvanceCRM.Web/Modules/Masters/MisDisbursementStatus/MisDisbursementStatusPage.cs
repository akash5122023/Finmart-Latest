using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(MisDisbursementStatusRow))]
    public class MisDisbursementStatusController : Controller
    {
        [Route("Masters/MisDisbursementStatus")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/MisDisbursementStatus/MisDisbursementStatusIndex.cshtml");
        }
    }
}