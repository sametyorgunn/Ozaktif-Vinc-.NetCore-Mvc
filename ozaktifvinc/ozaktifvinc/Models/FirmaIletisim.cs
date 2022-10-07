using System.ComponentModel.DataAnnotations;

namespace ozaktifvinc.Models
{
    public class FirmaIletisim
    {
        [Key]
        public int Id { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
    }
}
