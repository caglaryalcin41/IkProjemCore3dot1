using Dapper;
using IkProjemCore3dot1.Areas.Admin.Data;
using IkProjemCore3dot1.Areas.Admin.ViewModels;
using IkProjemCore3dot1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Linq;

namespace IkProjemCore3dot1.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        IConfiguration Configuration;
        public LoginController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Login()
        { 
            return View();
        }


        [HttpPost]
        public IActionResult Login(vm_LoginViewModel model)
        {
            if (model.KullaniciAdi != null && model.Sifre != null)
            {
                using var con = new SqlConnection(Configuration.GetConnectionString("PersonelContext"));
                if (ModelState.IsValid)
                {
                    vm_WebUserIds gelenRoleId = con.Query<vm_WebUserIds>($"select ct.RoleId as webItemId from [user] as u inner join ct_UserRole as ct on ct.UserId = u.Id where u.KullaniciAdi = '{model.KullaniciAdi}' and u.Sifre = '{model.Sifre}'").First();

                    if (gelenRoleId != null)
                    {
                        LoginUser.userRole = gelenRoleId.webItemId;
                    }
                }
            }

            return RedirectToAction("KisiListesi", new {Area="Admin",Controller ="Personel"});
        }



    }
}
