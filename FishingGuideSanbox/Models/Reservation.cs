using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class Reservation
    {
        public Customer Customer { get; set; }
        public Charter Charter { get; set; }
        public PaymentMethods PaymentMethod { get; set; }
    }
}