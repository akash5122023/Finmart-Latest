using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(CasesStageRow))]
    public class CasesStageController : Controller
    {
        [Route("Masters/CasesStage")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/CasesStage/CasesStageIndex.cshtml");
        }
    }
}