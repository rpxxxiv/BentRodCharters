using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishingGuideSanbox.Models
{
    public class NavigationLinkRepository
    {
        public List<NavigationLink> GetLinks()
        {
            List<NavigationLink> navLinks = new List<NavigationLink>();
            navLinks.Add(new NavigationLink() { Title = "Home", View = "HomePage", ControllerName = "Home" });
            navLinks.Add(new NavigationLink() { Title = "About Us", View = "AboutUs", ControllerName = "Home" });
            navLinks.Add(new NavigationLink() { Title = "Reserve Charter", View = "Index", ControllerName = "Charter" });
            navLinks.Add(new NavigationLink() { Title = "Blog", View = "Index", ControllerName = "Blog" });
            navLinks.Add(new NavigationLink() { Title = "Customer Feedback", View = "Index", ControllerName = "UserFeedback" });
            navLinks.Add(new NavigationLink() { Title = "Gallery", View = "Index", ControllerName = "Content" });
            return navLinks;
        }
    }
}