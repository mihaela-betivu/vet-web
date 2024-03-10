using System.Web.Mvc;
namespace eUseControl.Web.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult BlogList()
        {
            return View("BlogList");
        }

        public ActionResult BlogDetails()
        {
            return View("BlogDetails");
        }
    }
}