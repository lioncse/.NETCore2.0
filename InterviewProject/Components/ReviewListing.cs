using InterviewProject.Services.ActiveListingService;
using InterviewProject.Services.RatingReviewService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Components
{
    public class ReviewListing : ViewComponent
    {
        private readonly IRatingReviewService _ratingReviewService;
        public ReviewListing(IRatingReviewService ratingReviewService)
        {
            _ratingReviewService = ratingReviewService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _ratingReviewService.GetReviewList();
            return View(model);
        }
    }
}
