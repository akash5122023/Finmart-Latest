using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Operations.Pages
{

    [PageAuthorize(typeof(MisDisbursementProcessRow))]
    public class MisDisbursementProcessController : Controller
    {
        [Route("Operations/MisDisbursementProcess")]
        public ActionResult Index()
        {
            return View("~/Modules/Operations/MisDisbursementProcess/MisDisbursementProcessIndex.cshtml");
        }
    }
}