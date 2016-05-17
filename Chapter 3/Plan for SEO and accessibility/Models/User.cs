
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace Plan_for_SEO_and_accessibility.Models
{
    public class User
    {
        [Required(ErrorMessage ="First name is required")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string LastName { get; set; }

    }
}