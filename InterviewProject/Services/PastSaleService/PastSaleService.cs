using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Components;
using InterviewProject.Models;

namespace InterviewProject.Services.PastSaleService
{
    public class PastSaleService : IPastSaleService
    {
        public List<SaleModel> GetPastSaleList()
        {
            List<SaleModel> pastList = new List<SaleModel>
            {
                new SaleModel{
                   Photo="/AgentProfile/images/property/home5.jpg",
                   Represent="Seller",
                   Price="$900,000",
                    SaleDetails=new List<SaleDetail>{
                        new SaleDetail{
                             Address="3247 Greystone Dr • Jamul, CA 91935",
                             Price="$900,000",
                             Location="Jamul, CA",
                             Info="7 bed, 4 bath, 6,150 sqft",
                             Date="Sold date: 09/12/2017"
                        }
                    }
                },
                new SaleModel{
                   Photo="/AgentProfile/images/property/home4.jpg",
                   Represent="Buyer",
                   Price="$490,000",
                    SaleDetails=new List<SaleDetail>{
                        new SaleDetail{
                             Address="9951 Watergum Trl • Santee, CA 92071",
                             Price="$490,000",
                             Location="El Cajon, CA",
                             Info="6 bed, 5.5 bath, 5,505 sqft",
                             Date="Sold date: 07/21/2017"
                        }
                    }
                },
                new SaleModel{
                   Photo="/AgentProfile/images/property/home12.jpg",
                   Represent="Buyer",
                   Price="$529,000",
                    SaleDetails=new List<SaleDetail>{
                        new SaleDetail{
                             Address="627 Hawthorne Ave • El Cajon, CA 92020",
                             Price="$529,000",
                             Location="Santee, CA",
                             Info="6 bed, 5.5 bath, 5,505 sqft",
                             Date="Sold date: 09/11/2017"
                        }
                    }
                },
                new SaleModel{
                   Photo="/AgentProfile/images/property/home6.jpg",
                   Represent="Buyer",
                   Price="$555,000",
                    SaleDetails=new List<SaleDetail>{
                        new SaleDetail{
                             Address="9565 Janfred Way • La Mesa, CA 91942",
                             Price="$555,000",
                             Location="La Mesa, CA",
                             Info="6 bed, 5.5 bath, 5,505 sqft",
                             Date="Sold date: 07/11/2017"
                        }
                    }
                },
                new SaleModel{
                   Photo="/AgentProfile/images/property/home7.jpg",
                   Represent="Seller",
                   Price="$1,265,000",
                    SaleDetails=new List<SaleDetail>{
                        new SaleDetail{
                             Address="5160 Alzeda Dr • La Mesa, CA 91941",
                             Price="$1,265,000",
                             Location="La Mesa, CA",
                             Info="6 bed, 5.5 bath, 5,505 sqft",
                             Date="Sold date: 07/07/2017"
                        }
                    }
                }
            };
            return pastList;
        }
    }
}
