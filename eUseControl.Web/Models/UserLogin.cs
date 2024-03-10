using System.ComponentModel.DataAnnotations;

namespace eUseControl.Web.Models
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "Username or Email")]
        public string Credential { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}