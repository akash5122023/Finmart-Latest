using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Operations.Pages
{

    [PageAuthorize(typeof(MisInitialProcessRow))]
    public class MisInitialProcessController : Controller
    {
        [Route("Operations/MisInitialProcess")]
        public ActionResult Index()
        {
            return View("~/Modules/Operations/MisInitialProcess/MisInitialProcessIndex.cshtml");
        }
    }
}