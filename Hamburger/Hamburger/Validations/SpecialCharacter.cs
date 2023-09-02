using System.ComponentModel.DataAnnotations;

namespace Hamburger.Validations
{
	public class SpecialCharacter:ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value == null)
				return false;

			string input = value.ToString();

			// Define your list of special characters here
			string specialCharacters = "!@#$%^&*()_+[]{}|;:'\",.<>?/";

			return input.Any(c => specialCharacters.Contains(c));
		}
	}
}
