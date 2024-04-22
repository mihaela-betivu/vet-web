using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.Blog
{
    public class BDbTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string BlogName { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string Status { get; set; }
        
        public string Author { get; set; }
        
        [DataType(DataType.DateTime)]
        public Nullable<DateTime> PublishDate { get; set; }
    }
}
