using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.Footer
{
    public class Footer:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var footer = c.firmaIletisims.FirstOrDefault();
            if (footer == null)
            {
                return View();
            }
            else
            {
                return View(footer);
            }
        }
    }
}
