using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.HakkimizdaMaddeListele
{
    public class HakkimizdaMaddeListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var maddeler = c.hakkimizdaMaddelers.ToList();
            if (maddeler == null)
            {
                return View();
            }
            else
            {
                return View(maddeler);
            }
        }
    }
}
