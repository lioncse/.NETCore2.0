using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class AgentProfileModel
    {
        public AgentProfileModel()
        {
            AgentSkills = new List<AgentSkill>();
        }
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public double AgentInfoAvg { get; set; }
        public int AgentInfoTotalReviewCount { get; set; }
        public string About { get; set; }

        public List<AgentSkill> AgentSkills { get; set; }
        public AgentContactModel AgentContact { get; set; }

    }

    public class AgentSkill
    {
        public string Title { get; set; }
        public string Percentage { get; set; }

        public double Score { get; set; }

    }
}
