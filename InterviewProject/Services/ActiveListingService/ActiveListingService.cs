using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Models;

namespace InterviewProject.Services.ActiveListingService
{
    public class ActiveListingService : IActiveListingService
    {
        public List<ActiveListingModel> GetActiveListingList()
        {
            List<ActiveListingModel> objActiveListingModel = new List<ActiveListingModel>
            {
                new ActiveListingModel(){
                    ImageUrl="/AgentProfile/images/property/home1.jpg",
                    CurrentPrice="$345,000",
                    ChanePrice="6,5",
                    Address="472 Ponderosa Dr, Alpine",
                    Photo="12",
                    IsFeature=false,
                    ActiveListingFeatures=new List<ActiveListingFeature>{
                        new ActiveListingFeature(){
                            Bed="4",
                            Bath="3.0",
                            Sqft="2,785"
                        }
                    }
                },
                new ActiveListingModel(){
                    ImageUrl="/AgentProfile/images/property/home8.jpg",
                    CurrentPrice="$345,000",
                    ChanePrice="10",
                    Address="472 Ponderosa Dr, Alpine",
                    Photo="12",
                    IsFeature=true,
                    ActiveListingFeatures=new List<ActiveListingFeature>{
                        new ActiveListingFeature(){
                            Bed="4",
                            Bath="3.0",
                            Sqft="2,785"
                        }
                    }
                },
                new ActiveListingModel(){
                    ImageUrl="/AgentProfile/images/property/home11.jpg",
                    CurrentPrice="$345,000",
                    ChanePrice="",
                    Address="472 Ponderosa Dr, Alpine",
                    Photo="12",
                    IsFeature=false,
                    ActiveListingFeatures=new List<ActiveListingFeature>{
                        new ActiveListingFeature(){
                            Bed="4",
                            Bath="3.0",
                            Sqft="2,785"
                        }
                    }
                }

            };
            return objActiveListingModel;
        }
    }
}
