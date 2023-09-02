using Hamburger.Validations;
using System.ComponentModel.DataAnnotations;

namespace Hamburger.Models.ViewModels
{
	public class ResetPasswordVM
	{
        [Required]
        [EmailAddress]
        public string Email { get; set; }
		[Required]
		[StringLength(16, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
		[SpecialCharacter(ErrorMessage = "The field must contain at least one special character.")]
		[UpperCase(ErrorMessage = "The field must contain at least one uppercase letter.")]
		[Number(ErrorMessage = "The field must contain at least one number.")]
		public string Password { get; set; }
		[Required]
		public string ConfirmPassword { get; set; }
        public string Token { get; set; }
    }
}
