using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.AdminHakkimizdaListele
{
    public class AdminHakkimizdaListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var hak = c.hakkimizdas.FirstOrDefault();
            if(hak==null)
            {
                return View();
            }
            else
            {
                return View(hak);
            }
            

        }
    }
}
