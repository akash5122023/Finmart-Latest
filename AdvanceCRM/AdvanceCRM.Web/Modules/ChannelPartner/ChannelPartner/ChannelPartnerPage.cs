using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceCRM.ChannelPartner.Pages
{

    [PageAuthorize(typeof(ChannelPartnerRow))]
    public class ChannelPartnerController : Controller
    {
        [Route("ChannelPartner/ChannelPartner")]
        public ActionResult Index()
        {
            return View("~/Modules/ChannelPartner/ChannelPartner/ChannelPartnerIndex.cshtml");
        }
    }
}