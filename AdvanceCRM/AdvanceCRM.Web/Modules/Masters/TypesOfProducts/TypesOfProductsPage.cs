using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(TypesOfProductsRow))]
    public class TypesOfProductsController : Controller
    {
        [Route("Masters/TypesOfProducts")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/TypesOfProducts/TypesOfProductsIndex.cshtml");
        }
    }
}