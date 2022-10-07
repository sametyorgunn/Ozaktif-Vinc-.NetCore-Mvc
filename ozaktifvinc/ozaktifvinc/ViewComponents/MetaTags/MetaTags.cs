using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.MetaTags
{
    public class MetaTags:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var tag = c.metaTags.FirstOrDefault();
            return View(tag);
        }
    }
}
