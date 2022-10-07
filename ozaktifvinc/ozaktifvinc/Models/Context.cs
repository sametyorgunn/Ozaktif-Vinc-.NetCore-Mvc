using Microsoft.EntityFrameworkCore;

namespace ozaktifvinc.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=176.53.69.151\\MSSQLSERVER2019;User ID=ozaktifv_vinc;Password=yorgun.1292;Database=ozaktifv_vinc1;");
        }
        public DbSet<FirmaIletisim> firmaIletisims { get; set; }
        public DbSet<Galeri> galeris { get; set; }
        public DbSet<Hakkimizda> hakkimizdas { get; set; }
        public DbSet<Header> headers { get; set; }
        public DbSet<Hizmetler> hizmetlers { get; set; }
        public DbSet<IletisimMesaj> ıletisimMesajs { get; set; }
        public DbSet<HakkimizdaMaddeler>hakkimizdaMaddelers { get; set; }
        public DbSet<MetaTag> metaTags { get; set; }
        public DbSet<Giris> girises { get; set; }
        public DbSet<Slider> sliders { get; set; }
      
    }
}
