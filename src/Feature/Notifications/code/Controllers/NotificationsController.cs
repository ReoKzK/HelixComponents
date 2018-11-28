using System.Web.Mvc;
using Sitecore.Mvc.Controllers;

namespace HelixComponents.Feature.Notifications.Controllers
{
    public class NotificationsController : SitecoreController
    {
        public NotificationsController()
        {
            
        }

        public ActionResult Cookies()
        {
            return View();
        }

        public ActionResult HeaderNotification()
        {
            return View();
        }
    }
}