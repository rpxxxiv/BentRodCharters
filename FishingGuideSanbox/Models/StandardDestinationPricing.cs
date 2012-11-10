using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class StandardDestinationPricing:ICharterPricing
    {
        public int MaxPrice
        {
            get;
            set;
        }

        public int MinPrice
        {
            get;
            set;
        }

        public void GetPrice(Boat boat, Destination destination, int Occupancy = 0)
        {
            throw new NotImplementedException();
        }
    }
}