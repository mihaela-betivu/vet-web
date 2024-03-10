using System.Web.Mvc;
namespace eUseControl.Web.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Register()
        {
            return View("Register");
        }
    }
}