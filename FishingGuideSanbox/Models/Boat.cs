﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class Boat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
    }
}