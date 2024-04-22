using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Blog
{
    public class BlogDetailsData
    {
        public int Id { get; set; }
        public string BlogName { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string Status { get; set; }
        
        public string Author { get; set; }
        
        public Nullable<DateTime> PublishDate { get; set; }
    }
}
