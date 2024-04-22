using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Blog
{
    public class BlogDetailsResp
    {
        public BlogDetailsData Blog { get; set; }
        public bool Status { get; set; }
        public string StatusMsg { get; set; }
    }
}
