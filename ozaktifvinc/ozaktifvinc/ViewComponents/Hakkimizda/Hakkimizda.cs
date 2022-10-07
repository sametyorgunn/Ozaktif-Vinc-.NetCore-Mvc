using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.Hakkimizda
{
    public class Hakkimizda:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var hakkimizda = c.hakkimizdas.FirstOrDefault();
            return View(hakkimizda);
            
        }
    }
}
