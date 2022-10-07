using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ozaktifvinc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ozaktifvinc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(Giris p)
        {
            if(ModelState.IsValid)
            {
                Context c = new Context();
                var login = c.girises.Where(x => x.UserName == p.UserName && x.Password == p.Password).FirstOrDefault();
                if(login!=null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, p.UserName)
                    };
                    var useridentity = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                    await HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Yonetim");

                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
