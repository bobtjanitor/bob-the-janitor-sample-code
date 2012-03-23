using System.ComponentModel.DataAnnotations;

namespace SampleApplication.Models
{


    public class BasicDemoModel
    {
        public int Id;
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must have an email address")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]        
        public string State { get; set; }
        [Required]
        [RegularExpression(@"^\d[5]$", ErrorMessage = "Zip Code must have exactly 5 numbers")]
        [Display(Name = "Zip")]
        public int ZipCode { get; set; }
        public string Message { get; set; }
    }

    public interface IAddressModel
    {
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        int ZipCode { get; set; }
    }
}