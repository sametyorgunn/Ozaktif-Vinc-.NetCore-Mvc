using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ozaktifvinc.Models
{
    public class Galeri
    {
        [Key]
        public int Id { get; set; }
        public string ResimYazi { get; set; }
        public string ResimYol { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }
    }
}
