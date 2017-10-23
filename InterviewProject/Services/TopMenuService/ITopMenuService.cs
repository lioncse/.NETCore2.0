using InterviewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewProject.Services.TopMenuService
{
    public interface ITopMenuService
    {
        List<TopMenu> GetTopMenu();
    }
}
