﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IkProjemCore3dot1.Models
{
    public class User : BaseModel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}