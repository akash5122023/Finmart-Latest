using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.FinmartInsideSales.Pages
{

    [PageAuthorize(typeof(InsideSalesRow))]
    public class InsideSalesController : Controller
    {
        [Route("FinmartInsideSales/InsideSales")]
        public ActionResult Index()
        {
            return View("~/Modules/FinmartInsideSales/InsideSales/InsideSalesIndex.cshtml");
        }
    }
}