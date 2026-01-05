using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(TypesOfAccountsRow))]
    public class TypesOfAccountsController : Controller
    {
        [Route("Masters/TypesOfAccounts")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/TypesOfAccounts/TypesOfAccountsIndex.cshtml");
        }
    }
}