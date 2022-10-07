using System.ComponentModel.DataAnnotations;

namespace ozaktifvinc.Models
{
    public class IletisimMesaj
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Mesaj { get; set; }
    }
}
