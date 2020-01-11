using System.ComponentModel.DataAnnotations;

namespace BlazorFormSample.Models
{
    public class Address
    {
        [Required]
        public int StreetNumber { get; set; }
        
        [Required]
        public string StreetName { get; set; }
    }
}
