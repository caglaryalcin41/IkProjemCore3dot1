using IkProjemCore3dot1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IkProjemCore3dot1.ViewComponents
{
    public class AuthMenu  : ViewComponent
    {
        PersonelContext db;

        public AuthMenu(PersonelContext context)
        {
            db = context;
        }
        public IViewComponentResult Invoke()
        { 
          List<int> webItem = db.ct_RolePrivilege.Where(x => x.RoleId == 1).Select(x=>x.WebItemId).ToList();

            List<WebItem> webItems = db.WebItem.Where(x => x.Id != 1 && x.Id != 2 && x.Id != 3).Where(x => webItem.Contains(x.Id)).ToList();

            return View(webItems);
        }
    }
}
