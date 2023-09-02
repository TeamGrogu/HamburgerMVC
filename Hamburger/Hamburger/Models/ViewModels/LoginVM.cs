using Hamburger.Validations;
using System.ComponentModel.DataAnnotations;

namespace Hamburger.Models.ViewModels
{
    public class LoginVM
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
