﻿using CafeOtomasyonu.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOtomasyonu.Entities.Models
{
    public class Roller : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string FormName { get; set; }
        public string ControlName { get; set; }
        public string ControlCaption { get; set; }
        public bool Visible { get; set; }
    }
}
