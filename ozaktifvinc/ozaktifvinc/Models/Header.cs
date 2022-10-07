using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ozaktifvinc.Models
{
    public class Header
    {
        [Key]
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string AltBaslik { get; set; }
        public string HeaderButton { get; set; }
      
     
    }
}
