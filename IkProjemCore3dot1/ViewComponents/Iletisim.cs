using IkProjemCore3dot1.Models;
using Microsoft.AspNetCore.Mvc;

namespace IkProjemCore3dot1.ViewComponents
{
    public class Iletisim : ViewComponent
    { 
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
