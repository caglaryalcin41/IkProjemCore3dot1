using IkProjemCore3dot1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using IkProjemCore3dot1.Areas.Admin.ViewModels;
using IkProjemCore3dot1.Areas.Admin.Controllers;
using IkProjemCore3dot1.Areas.Admin.Data;

namespace IkProjemCore3dot1.ViewComponents
{
    public class AuthMenu  : ViewComponent
    {
        IConfiguration Configuration;

        public AuthMenu(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IViewComponentResult Invoke()
        {

            using var con = new SqlConnection(Configuration.GetConnectionString("PersonelContext"));

            //var webItems =  con.Execute(); 
 
            
            //var LoginRoleId =  con.Query($"select ur.RoleId from[User] as u  inner join[ct_UserRole] as ur on u.Id = ur.UserId where Adi = '{"Caglar"}'" ).First();

            int LoginUserRoleId = LoginUser.userRole;

            List<vm_WebUserIds> userItems = con.Query<vm_WebUserIds>($"select webItemId from [ct_RolePrivilege] where AktifMi = 1 and RoleId = {LoginUserRoleId}").ToList();
            List<vm_MenuAuth> KullanıcıIzinliItemları = new List<vm_MenuAuth> { };
             
            foreach (var item in userItems)
            { 

                vm_MenuAuth gelenItems = con.Query<vm_MenuAuth>(@"
SELECT     a.AreaName,   a.ControllerName,     a.ActionName FROM     (       SELECT    wi3.AreaName AS AreaName, ( SELECT  wi2.ControllerName FROM WebItem AS wi2 WHERE  wi2.Id = ( SELECT UpperId FROM WebItem AS wi  WHERE    wi.Id = @Item  )  AND wi2.ActionName IS NULL AND wi2.AreaName IS NULL ) AS ControllerName, ( SELECT  ActionName  FROM   WebItem AS wi  WHERE  wi.Id = @Item   AND wi.ControllerName IS NULL  AND wi.AreaName IS NULL) AS ActionName FROM WebItem AS wi3 WHERE  wi3.Id = ( SELECT UpperId   FROM   WebItem AS wi2   WHERE  wi2.Id = (  SELECT  UpperId  FROM    WebItem AS wi  WHERE wi.Id = @Item)  AND wi2.ActionName IS NULL  AND wi2.AreaName IS NULL )  AND wi3.ControllerName IS NULL  AND wi3.ActionName IS NULL  ) AS a;", new { @Item = item.webItemId }).FirstOrDefault() ;
                if (gelenItems != null)
                {

                    KullanıcıIzinliItemları.Add(gelenItems);
                }

            }

           


            return View(KullanıcıIzinliItemları);
        }
    }
}
