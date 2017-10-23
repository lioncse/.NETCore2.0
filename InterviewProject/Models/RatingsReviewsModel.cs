using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Models
{
    public class RatingsReviewsModel
    {
        public RatingsReviewsModel()
        {
            Ratings = new List<AgentSkill>();
            Rating = new AgentSkill();
        }
        public string Date { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }
        public AgentSkill Rating { get; set; }

        public List<AgentSkill> Ratings { get; set; }


    }
}
