using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ozaktifvinc.Models
{
    public class Hakkimizda
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public string ResimYol { get; set; }
        [NotMapped]
        public IFormFile Resim { get; set; }
    }
}
