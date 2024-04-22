using System;
using System.Collections.Generic;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Web.Extension;
using eUseControl.Web.Models;

namespace eUseControl.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly ISession _session;

        public BlogController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        
        [AdminMod]
        public ActionResult AdminBlogList()
        {
            bool isAdmin = true;
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };

            var blogList = _session.BlogList(isAdmin);
            
            // BlogData b = new BlogData();
            // b.Blogs = new List<string> { "Blog #1", "Blog #2", "Blog #3", "Blog #4" };
            
            ViewBag.username = u.Username;
            ViewBag.blogList = blogList.Blogs;
            
            return View("AdminBlogList");
        }
        
        public ActionResult BlogList()
        {
            bool isAdmin = false;
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };

            var blogList = _session.BlogList(isAdmin);
            
            // BlogData b = new BlogData();
            // b.Blogs = new List<string> { "Blog #1", "Blog #2", "Blog #3", "Blog #4" };
            
            ViewBag.username = u.Username;
            ViewBag.blogList = blogList.Blogs;
            
            return View("BlogList");
        }

        public ActionResult BlogDetails()
        {
            var user = System.Web.HttpContext.Current.GetMySessionObject();
            UserData u = new UserData
            {
                Username = user.Username,
            };
            
            var blogId = Request.QueryString["blog"];
            var blogDetails = _session.BlogDetails(Int32.Parse(blogId));

            ViewBag.username = u.Username;
            ViewBag.blogDetails = blogDetails.Blog;

            return View("BlogDetails");
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