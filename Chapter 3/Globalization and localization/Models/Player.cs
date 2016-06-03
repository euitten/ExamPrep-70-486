using System.ComponentModel.DataAnnotations;

namespace Globalization_and_localization.Models
{
    public class Player
    {
        [Required(ErrorMessage = "Required field")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Required(ErrorMessageResourceType = typeof(Globalization_and_localization.Resources.Views.RazorLocalization), ErrorMessageResourceName = "LastNameRequired")]
        [Display(ResourceType = typeof(Globalization_and_localization.Resources.Views.RazorLocalization), Name ="LastName" )]
        public string LastName { get; set; }
        public int Ranking { get; set; } // standaard validatie omdat integer is. Geen validatie wanneer string.
    }
}