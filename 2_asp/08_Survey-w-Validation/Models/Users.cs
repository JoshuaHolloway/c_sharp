using System.ComponentModel.DataAnnotations;
namespace _08_Survey_w_Validation.Models
{
    public class Person
    {
        
        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
        public string Language { get; set; }
        public string Comment { get; set; }
    }
}