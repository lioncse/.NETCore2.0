using InterviewProject.Components;
using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Services.AgentProfileService
{
    public interface IAgentProfileService
    {
        AgentProfileModel GetAgentProfile();
    }
}
