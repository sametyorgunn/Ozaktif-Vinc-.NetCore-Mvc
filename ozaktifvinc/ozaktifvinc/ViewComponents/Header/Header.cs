using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.Header
{
    public class Header:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var header = c.headers.FirstOrDefault();
            return View(header);
        }
    }
}
