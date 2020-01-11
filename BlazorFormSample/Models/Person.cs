using System.ComponentModel.DataAnnotations;

namespace BlazorFormSample.Models
{
    public class Person
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [ValidateComplexType]
        public Address Address { get; set; }
    }
}
