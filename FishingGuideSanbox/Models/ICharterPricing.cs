using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingGuideSanbox.Models
{
    public interface ICharterPricing
    {
        int MaxPrice { get; set; }
        int MinPrice { get; set; }
        void GetPrice(Boat boat, Destination destination, int Occupancy = 0);

    }
}
