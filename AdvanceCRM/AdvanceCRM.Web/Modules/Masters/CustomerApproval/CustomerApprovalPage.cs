using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.Masters.Pages
{

    [PageAuthorize(typeof(CustomerApprovalRow))]
    public class CustomerApprovalController : Controller
    {
        [Route("Masters/CustomerApproval")]
        public ActionResult Index()
        {
            return View("~/Modules/Masters/CustomerApproval/CustomerApprovalIndex.cshtml");
        }
    }
}