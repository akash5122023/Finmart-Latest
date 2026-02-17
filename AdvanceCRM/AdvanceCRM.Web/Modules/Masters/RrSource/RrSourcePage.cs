using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(RrSourceRow))]
    public class RrSourceController : Controller
    {
        [Route("Masters/RrSource")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/RrSource/RrSourceIndex.cshtml");
        }
    }
}