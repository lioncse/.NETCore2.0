using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class ActiveListingModel
    {
        public ActiveListingModel()
        {
            ActiveListingFeatures = new List<ActiveListingFeature>();
        }
        public string ImageUrl { get; set; }
        public string CurrentPrice { get; set; }
        public string ChanePrice { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public bool IsFeature { get; set; }

        public List<ActiveListingFeature> ActiveListingFeatures { get; set; }
       
    }

    public class ActiveListingFeature
    {
        public string Bed { get; set; }
        public string Bath { get; set; }
        public string Sqft { get; set; }

    }
}
