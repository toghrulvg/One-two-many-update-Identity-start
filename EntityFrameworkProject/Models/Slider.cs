using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkProject.Models
{
    public class Slider : BaseEntity
    {
        public string  Image { get; set; }
        [NotMapped]
        [Required(ErrorMessage ="Can't be empty")]
        public IFormFile Photo { get; set; }
    }
}
