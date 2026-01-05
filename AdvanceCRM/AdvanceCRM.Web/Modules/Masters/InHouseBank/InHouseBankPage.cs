using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(InHouseBankRow))]
    public class InHouseBankController : Controller
    {
        [Route("Masters/InHouseBank")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/InHouseBank/InHouseBankIndex.cshtml");
        }
    }
}