using System.Collections.Generic;
using System.Web.Mvc;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult BlogList()
        {
            
            BlogData b = new BlogData();
            b.Blogs = new List<string> { "Blog #1", "Blog #2", "Blog #3", "Blog #4" };
            
            return View("BlogList", b);
        }

        public ActionResult BlogDetails()
        {
            var blog = Request.QueryString["blog"];

            BlogData b = new BlogData();
            b.SingleBlog = blog;

            
            return View("BlogDetails", b);
        }
        
        [HttpPost]
        public ActionResult BlogDetails(string btn)
        {
            return RedirectToAction("BlogDetails", "Blog", new { blog = btn });
        }
        
        // [HttpPost]
        // public ActionResult BlogDetails(string btn)
        // {
        //     return Json(new { RedirectUrl = Url.Action("BlogDetails", new { b = btn }) });
        // }
    }
}