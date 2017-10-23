using InterviewProject.Services.ActiveListingService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Components
{
    public class ActiveListing : ViewComponent
    {
        private readonly IActiveListingService _activeListingService;
        public ActiveListing(IActiveListingService activeListingService)
        {
            _activeListingService = activeListingService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _activeListingService.GetActiveListingList();

            return View(model);
            

        }
    }
}
