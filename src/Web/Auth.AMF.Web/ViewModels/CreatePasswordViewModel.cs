using Auth.AMF.Web.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Auth.AMF.Web.ViewModels
{
    public class CreatePasswordViewModel
    {
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [PasswordValidation]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public bool AcceptTerms { get; set; }
    }
}
