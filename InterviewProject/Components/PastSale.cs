using InterviewProject.Services.PastSaleService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Components
{
    public class PastSale : ViewComponent
    {
        private readonly IPastSaleService _pastSaleService;
        public PastSale(IPastSaleService pastSaleService)
        {
            _pastSaleService = pastSaleService;
        }
        public IViewComponentResult Invoke()
        {
            var model = _pastSaleService.GetPastSaleList();

            return View(model);
        }
    }
}
