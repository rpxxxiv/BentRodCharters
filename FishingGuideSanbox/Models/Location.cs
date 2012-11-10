using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingGuideSanbox.Models
{
    public class Location
    {
        public int ID { get; set; }
        public long Latitude { get; set; }
        public long Longitude { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        
    }
}
