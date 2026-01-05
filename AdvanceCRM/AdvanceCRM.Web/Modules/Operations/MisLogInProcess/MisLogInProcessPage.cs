using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Operations.Pages
{

    [PageAuthorize(typeof(MisLogInProcessRow))]
    public class MisLogInProcessController : Controller
    {
        [Route("Operations/MisLogInProcess")]
        public ActionResult Index()
        {
            return View("~/Modules/Operations/MisLogInProcess/MisLogInProcessIndex.cshtml");
        }
    }
}