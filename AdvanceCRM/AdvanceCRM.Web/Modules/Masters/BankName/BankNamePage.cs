using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(BankNameRow))]
    public class BankNameController : Controller
    {
        [Route("Masters/BankName")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/BankName/BankNameIndex.cshtml");
        }
    }
}