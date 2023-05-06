
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkProjemCore3dot1.Models
{
    public class ct_UserRole : BaseModel
    {
        public int RoleId { get; set; }
        public int UserId{ get; set; }
    }
}