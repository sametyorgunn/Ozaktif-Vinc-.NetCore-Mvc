using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.AdminHakkimizdaMaddeListele
{
    public class AdminHakkimizdaMaddeListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var hakkimizdaMaddeler = c.hakkimizdaMaddelers.ToList();
            if(hakkimizdaMaddeler==null)
            {
                return View();
            }
            else
            {
                return View(hakkimizdaMaddeler);
            }
            
        }
    }
}
