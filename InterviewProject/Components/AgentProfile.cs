using InterviewProject.Services.AgentProfileService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Components
{
    public class AgentProfile : ViewComponent
    {
        private readonly IAgentProfileService _agentProfileService;
        public AgentProfile(IAgentProfileService agentProfileService)
        {
            _agentProfileService = agentProfileService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _agentProfileService.GetAgentProfile();

            return View(model);
        }
    }
}
