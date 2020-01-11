using System.ComponentModel.DataAnnotations;

namespace BlazorFormSample.Models
{
    public class Register
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
