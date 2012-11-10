using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class Charter
    {
        public int ID { get; set; }
        public Boat Boat { get; set; }
        public Destination Destination { get; set; }
        public int Occupancy { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICharterPricing Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}