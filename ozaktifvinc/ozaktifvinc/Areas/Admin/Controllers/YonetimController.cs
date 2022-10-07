using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ozaktifvinc.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class YonetimController : Controller
    {
        private readonly IWebHostEnvironment _webHost;

        public YonetimController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GaleriEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> GaleriEkle(Galeri galeri)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(galeri.Resim.FileName);
            string extension = Path.GetExtension(galeri.Resim.FileName);
            galeri.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;//yol == path
            string path = Path.Combine(wwwRootPath + "/Resimler/Galeri", filename);  // + DateTime.Now.ToString("yymmssfff") 
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await galeri.Resim.CopyToAsync(filestream);    //.CopyToAsync
            }
            c.galeris.Add(galeri);
            c.SaveChanges();
            return RedirectToAction("GaleriEkle", "Yonetim");
        }

        public IActionResult GaleriListele()
        {
            Context c = new Context();
            var galeri = c.galeris.ToList();
            return View(galeri);
        }

        public IActionResult GaleriDuzenle(int id)
        {
            Context c = new Context();
            var duzenlenecek = c.galeris.Find(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> GaleriDuzenle(Galeri galeri)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(galeri.Resim.FileName);
            string extension = Path.GetExtension(galeri.Resim.FileName);
            galeri.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;//yol == path
            string path = Path.Combine(wwwRootPath + "/Resimler/Galeri", filename);  // + DateTime.Now.ToString("yymmssfff") 
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await galeri.Resim.CopyToAsync(filestream);    //.CopyToAsync
            }
            c.galeris.Update(galeri);
            c.SaveChanges();
            return RedirectToAction("GaleriListele", "Yonetim");
        }
        public IActionResult GaleriSil(int id)
        {
            Context c = new Context();
            var silincek = c.galeris.Find(id);
            c.Remove(silincek);
            c.SaveChanges();
            return RedirectToAction("GaleriListele", "Yonetim");
        }





        public IActionResult FirmaIletisimEkle()
        {
            Context c = new Context();
            var iletisim = c.firmaIletisims.FirstOrDefault();
            return View(iletisim);
        }
        [HttpPost]
        public IActionResult FirmaIletisimEkle(FirmaIletisim iletisim)
        {
            Context c = new Context();
            c.firmaIletisims.Update(iletisim);
            c.SaveChanges();
            return RedirectToAction("FirmaIletisimEkle", "Yonetim");
        }






        public IActionResult HakkimizdaEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> HakkimizdaEkle(Hakkimizda hakkimizda)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(hakkimizda.Resim.FileName);
            string extension = Path.GetExtension(hakkimizda.Resim.FileName);
            hakkimizda.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;//yol == path
            string path = Path.Combine(wwwRootPath + "/Resimler/Hakkimizda", filename);  // + DateTime.Now.ToString("yymmssfff") 
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await hakkimizda.Resim.CopyToAsync(filestream);    //.CopyToAsync
            }
            c.hakkimizdas.Add(hakkimizda);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaEkle", "Yonetim");
        }

        public IActionResult HakkimizdaMaddeEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HakkimizdaMaddeEkle(HakkimizdaMaddeler hakkimizda)
        {
           
            using(var c = new Context())
            {
                c.hakkimizdaMaddelers.Add(hakkimizda);
                c.SaveChanges();
                return RedirectToAction("HakkimizdaMaddeEkle", "Yonetim");
            }
        }
        public IActionResult HakkimizdaMaddeDuzenle(int id)
        {
            Context c = new Context();
            var madde = c.hakkimizdaMaddelers.Find(id);

            return View(madde);
        }
        public IActionResult HakkimizdaMaddeSil(int id)
        {
            Context c = new Context();
            var madde = c.hakkimizdaMaddelers.Find(id);
            c.hakkimizdaMaddelers.Remove(madde);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaMaddeEkle", "Yonetim");
        }
        [HttpPost]
        public IActionResult HakkimizdaMaddeDuzenle(HakkimizdaMaddeler hakkimizda)
        {

            using (var c = new Context())
            {
                c.hakkimizdaMaddelers.Update(hakkimizda);
                c.SaveChanges();
                return RedirectToAction("HakkimizdaMaddeEkle", "Yonetim");
            }
        }
        public IActionResult HakkimizdaDuzenle(int id)
        {
            Context c = new Context();
            var duzenlenecek = c.hakkimizdas.Find(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public async Task<IActionResult> HakkimizdaDuzenle(Hakkimizda hakkimizda)
        {
            Context c = new Context();
            string wwwRootPath = _webHost.WebRootPath;
            string filename = Path.GetFileNameWithoutExtension(hakkimizda.Resim.FileName);
            string extension = Path.GetExtension(hakkimizda.Resim.FileName);
            hakkimizda.ResimYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;//yol == path
            string path = Path.Combine(wwwRootPath + "/Resimler/Hakkimizda", filename);  // + DateTime.Now.ToString("yymmssfff") 
            using (var filestream = new FileStream(path, FileMode.Create))
            {
                await hakkimizda.Resim.CopyToAsync(filestream);    //.CopyToAsync
            }
            c.hakkimizdas.Update(hakkimizda);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaEkle", "Yonetim");
        }
        public IActionResult HakkimizdaSil(int id)
        {
            Context c = new Context();
            var silincek = c.hakkimizdas.Find(id);
            c.Remove(silincek);
            c.SaveChanges();
            return RedirectToAction("HakkimizdaEkle", "Yonetim");
        }





        public IActionResult HeaderEkle()
        {
            Context c = new Context();
            var header = c.headers.FirstOrDefault();
            return View(header);
        }
        [HttpPost]
        public IActionResult HeaderEkle(Header header)
        {
            Context c = new Context();
            c.headers.Update(header);
            c.SaveChanges();
            return RedirectToAction("HeaderEkle", "Yonetim");
        }

      
        public IActionResult HeaderSil(int id)
        {
            Context c = new Context();
            var silincek = c.headers.Find(id);
            c.Remove(silincek);
            return RedirectToAction("HeaderEkle", "Yonetim");
        }


        public IActionResult HizmetEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HizmetEkle(Hizmetler hizmet)
        {
            Context c = new Context();
            c.hizmetlers.Add(hizmet);
            c.SaveChanges();
            return RedirectToAction("HizmetEkle", "Yonetim");
        }


        public IActionResult HizmetDuzenle(int id)
        {
            Context c = new Context();
            var duzenlenecek = c.hizmetlers.Find(id);
            return View(duzenlenecek);
        }
        [HttpPost]
        public IActionResult HizmetDuzenle(Hizmetler hizmet)
        {
            Context c = new Context();

            c.hizmetlers.Update(hizmet);
            c.SaveChanges();
            return RedirectToAction("HizmetEkle", "Yonetim");
        }
        public IActionResult HizmetSil(int id)
        {
            Context c = new Context();
            var silincek = c.hizmetlers.Find(id);
            c.Remove(silincek);
            c.SaveChanges();
            return RedirectToAction("HizmetEkle", "Yonetim");
        }

        public IActionResult Mesajlar()
        {
            Context c = new Context();
            var mesajlar = c.ıletisimMesajs.ToList();
            return View(mesajlar);
        }

        public IActionResult MesajSil(int id)
        {
            Context c = new Context();
            var silincek = c.ıletisimMesajs.Find(id);
            c.ıletisimMesajs.Remove(silincek);
            c.SaveChanges();
            return RedirectToAction("Mesajlar", "Yonetim");
        }
        public IActionResult TagsEkle()
        {
            Context c = new Context();
            var taglar = c.metaTags.FirstOrDefault();
            return View(taglar);
        }
        [HttpPost]
        public IActionResult TagsEkle(MetaTag tag)
        {
            Context c = new Context();
            c.metaTags.Update(tag);
            c.SaveChanges();
            return RedirectToAction("TagsEkle","Yonetim");
        }

        public IActionResult SliderEkle()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SliderEkle(Slider slider)
        {
            if(ModelState.IsValid)
            {
                using (var c = new Context())
                {
                    string wwwRootPath = _webHost.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(slider.SliderResim.FileName);
                    string extension = Path.GetExtension(slider.SliderResim.FileName);
                    slider.SliderYol = filename = filename + DateTime.Now.ToString("yymmssfff") + extension;//yol == path
                    string path = Path.Combine(wwwRootPath + "/Resimler/Slider", filename);  // + DateTime.Now.ToString("yymmssfff") 
                    using (var filestream = new FileStream(path, FileMode.Create))
                    {
                        await slider.SliderResim.CopyToAsync(filestream);    //.CopyToAsync
                    }
                    c.sliders.Add(slider);
                    c.SaveChanges();
                    return RedirectToAction("SliderEkle", "Yonetim");
                }
            }
            return View();
        }

        public IActionResult SliderSil(int id)
        {
            using (var c = new Context())
            {
               var slincek =  c.sliders.Find(id);
                c.sliders.Remove(slincek);
                c.SaveChanges();
                return RedirectToAction("SliderEkle", "Yonetim");
            }
        }

        public IActionResult SliderListele()
        {
            Context c = new Context();
            var resimler = c.sliders.ToList();
            return View(resimler);
        }



    }
}
