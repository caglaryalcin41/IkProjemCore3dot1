﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IkProjemCore3dot1.Models
{
    [Table("Unvan")]
    public class Unvan : BaseModel
    {   
        public virtual List<Personel> Personel { get; set; }
    }
}