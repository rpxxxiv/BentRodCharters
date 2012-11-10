using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class Destination
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Location Location { get; set; }
    }
}