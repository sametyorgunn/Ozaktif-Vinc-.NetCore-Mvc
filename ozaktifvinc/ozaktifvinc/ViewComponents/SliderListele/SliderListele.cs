using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System.Linq;

namespace ozaktifvinc.ViewComponents.SliderListele
{
    public class SliderListele:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            var sliders = c.sliders.ToList();
            return View(sliders);
                
        }
    }
}
