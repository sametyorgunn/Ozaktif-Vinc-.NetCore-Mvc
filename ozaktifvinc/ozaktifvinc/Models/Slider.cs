using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ozaktifvinc.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        public string SliderYol { get; set; }
        [NotMapped]
        public IFormFile SliderResim { get; set; }
    }
}
