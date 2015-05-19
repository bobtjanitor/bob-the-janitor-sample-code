using System.ComponentModel.DataAnnotations;
using SampleApplication.Web.CustomValidators;

namespace SampleApplication.Web.Models
{
    public class ValidationDemoModel
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Job Title is Required")]
        public string JobTitle { get; set; }
        
        [GreaterThen(BaseNumber = 2,ErrorMessage = "Test") ]
        public int Age { get; set; }
    }
}