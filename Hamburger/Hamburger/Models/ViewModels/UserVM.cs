using System.ComponentModel.DataAnnotations;

namespace Hamburger.Models.ViewModels
{
    public class UserVM
    {
        public LoginVM? LoginVM { get; set; }
        public RegisterVM? RegisterVM { get; set; }
    }
}
