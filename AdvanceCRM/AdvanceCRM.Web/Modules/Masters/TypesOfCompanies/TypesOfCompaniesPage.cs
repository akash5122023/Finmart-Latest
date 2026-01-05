using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(TypesOfCompaniesRow))]
    public class TypesOfCompaniesController : Controller
    {
        [Route("Masters/TypesOfCompanies")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/TypesOfCompanies/TypesOfCompaniesIndex.cshtml");
        }
    }
}