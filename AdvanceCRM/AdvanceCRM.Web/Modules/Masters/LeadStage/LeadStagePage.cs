using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(LeadStageRow))]
    public class LeadStageController : Controller
    {
        [Route("Masters/LeadStage")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/LeadStage/LeadStageIndex.cshtml");
        }
    }
}