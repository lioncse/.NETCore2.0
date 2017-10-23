using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Components;
using InterviewProject.Models;

namespace InterviewProject.Services.AgentProfileService
{
    public class AgentProfileService : IAgentProfileService
    {
        public AgentProfileModel GetAgentProfile()
        {
            AgentProfileModel agentProfile = new AgentProfileModel();
            agentProfile.Name = "Melissa Crosby";
            agentProfile.ImageUrl = "/AgentProfile/images/agent5.png";
            agentProfile.AgentInfoAvg = 4.5;
            agentProfile.AgentInfoTotalReviewCount = 16;

            agentProfile.AgentSkills = new List<AgentSkill>()
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
            };

            agentProfile.About = "<h4 class='l-border'>About</h4>" +
           "<p>" +
               "Being a full-service Realtor since 2007, I have been baptized by fire in a very tough housing market.I have successfully closed over 60 transactions and" +
            "processed over 70 short sales both as the listing agent and some for other agents. I am very knowledgeable about lenders and their processes.I strive to" +
            "exceed expectations and never forget that I am always accountable to my clients." +
          "</p>" +
          "<p>" +
            "My objective is to establish relationships for life, not just for the current transaction.I enjoy assisting home buyers and sellers to get moved to a" +
            "better place, one that is exciting." +
          "</p>" +
          "<p class='l-small'>" +
           "<strong>Brokerage:</strong> Berkshire Hathaway HomeServices Elite Real Estate" +
           "</p>" +
           "<p class='l-small'>" +
            "<strong>Specialties:</strong> Property Management, Buyer’s Agent, Listing Agent…" +
           "</p>" +
           "<p class='l-small'>" +
           "<strong>License Number(s):</strong> #5452129" +
        "</p>";

            return agentProfile;
        }
    }
}
