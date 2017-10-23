using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class TopMenu
    {
        public TopMenu()
        {
            SubCategories=new List<SubCategory>();
        }
        public string ParentMenuName { get; set; }

        public List<SubCategory> SubCategories { get; set; }
    }
    public class SubCategory
    {
        public string Name { get; set; }
        public string Url { get; set; }


    }
}
