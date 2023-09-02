using System.ComponentModel.DataAnnotations;

namespace Hamburger.Validations
{
	public class Number:ValidationAttribute
	{
		public override bool IsValid(object value)
		{
			if (value == null)
				return false;

			string input = value.ToString();

			return input.Any(char.IsDigit);
		}
	}
}
