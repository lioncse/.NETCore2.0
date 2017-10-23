using InterviewProject.Services.TopMenuService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Components
{
    public class TopMenuMobile : ViewComponent
    {
        private readonly ITopMenuService _topMenuService;

        public TopMenuMobile(ITopMenuService topMenuService)
        {
            _topMenuService = topMenuService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _topMenuService.GetTopMenu();

            return View(model);
        }
    }
}
