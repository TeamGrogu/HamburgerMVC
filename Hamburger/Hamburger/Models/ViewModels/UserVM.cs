using Hamburger.Validations;
using System.ComponentModel.DataAnnotations;

namespace Hamburger.Models.ViewModels
{
    public class UserVM
    {
        [Required]
        public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string UserName { get; set; }
		[Required]
		[StringLength(16, ErrorMessage = "{0} length must be between {2} and {1}.", MinimumLength = 6)]
		[SpecialCharacter(ErrorMessage = "The field must contain at least one special character.")]
		[UpperCase(ErrorMessage = "The field must contain at least one uppercase letter.")]
		[Number(ErrorMessage = "The field must contain at least one number.")]
		public string Password { get; set; }
		[Required]
		[EmailCheck(ErrorMessage = "Email is already in use.")]
		public string Email { get; set; }
		[Required]
		public string Address { get; set; }
		[Required]
		public string PhoneNumber { get; set; }
        public LoginVM LoginVM { get; set; }
    }
}
