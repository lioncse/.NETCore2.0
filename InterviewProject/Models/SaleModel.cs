using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class SaleModel
    {
        public SaleModel()
        {
            SaleDetails = new List<SaleDetail>();
        }
        public string Photo { get; set; }
        public string Represent { get; set; }
        public string Price { get; set; }

        public List<SaleDetail> SaleDetails { get; set; }
    }

    public class SaleDetail
    {
        public string Price { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }
        public string Date { get; set; }
        
    }
}
