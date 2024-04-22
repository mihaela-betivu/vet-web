using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using eUseControl.BusinessLogic.DBModel;
using eUseControl.Domain.Entities.Blog;
using eUseControl.Helpers;

namespace eUseControl.BusinessLogic.Core
{
    public class BlogApi
    {
        internal BlogListResp BlogListAction(bool isAdmin)
        {
            List<BDbTable> result;

            using (var db = new BlogContext())
            {
                result = isAdmin ? db.Blogs.ToList() : db.Blogs.Where(b => b.Status == "Publish").ToList();
            }

            var blogs = new List<BlogListData>();

            foreach (var b in result)
            {
                blogs.Add(new BlogListData
                {
                    Id = b.Id,
                    BlogName = b.BlogName,
                    ShortDescription = b.ShortDescription,
                    Author = b.Author,
                    Status = b.Status,
                    PublishDate = b.PublishDate
                });
            }
            
            return new BlogListResp() { 
                Blogs = blogs,
                Status = true,                     
                StatusMsg = "Success"
            };
        }
        
        internal BlogDetailsResp BlogDetailsAction(int blogId)
        {
            BDbTable result;

            using (var db = new BlogContext())
            {
                result = db.Blogs.FirstOrDefault(b => b.Id == blogId);
            }

            if (result == null)
                return new BlogDetailsResp()
                {
                    Blog = null,
                    Status = false,
                    StatusMsg = "Blogul nu a putut fi incarcat."
                };

            var blog = new BlogDetailsData()
            {
                Id = result.Id,
                BlogName = result.BlogName,
                ShortDescription = result.ShortDescription,
                Author = result.Author,
                Status = result.Status,
                PublishDate = result.PublishDate
            };
            
            
            return new BlogDetailsResp() { 
                Blog = blog,
                Status = true,                     
                StatusMsg = "Success"
            };
        }
    }
}
