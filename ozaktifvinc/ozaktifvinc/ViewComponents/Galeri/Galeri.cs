using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.Galeri
{
    public class Galeri:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var galeri = c.galeris.ToList();
            return View(galeri);
        }
    }
}
