using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(MisDirectIndirectRow))]
    public class MisDirectIndirectController : Controller
    {
        [Route("Masters/MisDirectIndirect")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/MisDirectIndirect/MisDirectIndirectIndex.cshtml");
        }
    }
}