﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}