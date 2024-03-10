using System.Web.Mvc;
namespace eUseControl.Web.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View("Login");
        }
    }
}