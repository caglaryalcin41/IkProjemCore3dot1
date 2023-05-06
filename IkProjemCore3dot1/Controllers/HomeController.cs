using IkProjemCore3dot1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IkProjemCore3dot1.Controllers
{
    public class HomeController : Controller
    {
 
        PersonelContext db;

        public HomeController(PersonelContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            var personelListesi = db.Personel41.Include("Unvan2").Where(x => x.AktifMi == 1)?.ToList();
            return View(personelListesi);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
