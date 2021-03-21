using System.ComponentModel.DataAnnotations;

namespace Auth.AMF.Web.Extensions
{
    public class PasswordValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int force = 0;

            if(force == 0)
            {
                return new ValidationResult("Senha muito Fraca");
            }

            return ValidationResult.Success;
        }
    }
}
