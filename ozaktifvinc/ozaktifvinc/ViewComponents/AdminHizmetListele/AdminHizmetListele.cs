using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.AdminHizmetListele
{
    public class AdminHizmetListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var hizmetler = c.hizmetlers.ToList();
            if (hizmetler == null)
            {
                return View();
            }
            else
            {
                return View(hizmetler);
            }
        }
    }
}
