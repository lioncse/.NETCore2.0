using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Components;
using InterviewProject.Models;

namespace InterviewProject.Services.RatingReviewService
{
    public class RatingReviewService : IRatingReviewService
    {
        public List<RatingsReviewsModel> GetReviewList()
        {
            List<RatingsReviewsModel> reviewList = new List<RatingsReviewsModel>
            {
                new RatingsReviewsModel{
                    Date="09/24/2017",
                    Name="Russroberts",
                    Address="Bought a home in 2017 in El Cajon, CA",
                    Description="Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market. I have successfully closed over 60 transactions and processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes. I strive to exceed expectations and never forget that I am always accountable to my clients.",
                    Rating=new AgentSkill()
                    {
                         Title="Local knowledge",
                          Score=4.5,
                          Percentage="90%"
                    },
                    Ratings=new List<AgentSkill>
                    {
                            new AgentSkill{
                                        Title="Local knowledge",
                                        Score=4.5,
                                        Percentage="90%"
                            },
                        new AgentSkill{
                              Title="Process expertise",
                              Score=4.2,
                              Percentage="84%"
                          },
                          new AgentSkill{
                              Title="Responsiveness",
                              Score=5.0,
                              Percentage="100%"
                          },
                          new AgentSkill{
                              Title="Negotiation Skills",
                              Score=4.1,
                              Percentage="82%"

                          }
                    }
                },
                new RatingsReviewsModel{
                    Date="09/24/2017",
                    Name="Russroberts",
                    Address="Bought a home in 2017 in El Cajon, CA",
                    Description="Most important to me was communication and Mark saw that every question or concern of ours we met with full and complete information. In most cases, Mark delivered information to us before we even had to ask. I look forward to working with Mark in the future because I know that I can trust him to",
                    Rating=new AgentSkill()
                    {
                         Title="Local knowledge",
                          Score=4.5,
                          Percentage="90%"
                    },
                    Ratings=new List<AgentSkill>
                    {
                            new AgentSkill{
                                        Title="Local knowledge",
                                        Score=4.5,
                                        Percentage="90%"
                            },
                        new AgentSkill{
                              Title="Process expertise",
                              Score=4.2,
                              Percentage="84%"
                          },
                          new AgentSkill{
                              Title="Responsiveness",
                              Score=5.0,
                              Percentage="100%"
                          },
                          new AgentSkill{
                              Title="Negotiation Skills",
                              Score=4.1,
                              Percentage="82%"

                          }
                    }
                }
            };
            return reviewList;
        }
    }
}
