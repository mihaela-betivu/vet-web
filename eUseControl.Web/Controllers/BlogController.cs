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
            //cream o lista de bloguri
            b.Blogs = new List<string> { "Blog #1", "Blog #2", "Blog #3", "Blog #4" };
            
            //trimitem lista in view
            return View("BlogList", b);
        }

        public ActionResult BlogDetails()
        {
            //extragem obiectul din request
            var blog = Request.QueryString["blog"];

            // cream un obiect
            BlogData b = new BlogData();
            //obiectului creat ii atribuim obiectul din request
            b.SingleBlog = blog;

            //returnam view-ul si trimitem obiectul in view
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