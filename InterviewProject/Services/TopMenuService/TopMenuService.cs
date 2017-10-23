using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterviewProject.Models;

namespace InterviewProject.Services.TopMenuService
{
    public class TopMenuService : ITopMenuService
    {
        public List<TopMenu> GetTopMenu()
        {
            List<TopMenu> topMenu = new List<TopMenu>{new TopMenu() {
                ParentMenuName = "Buy",
                SubCategories = new List<SubCategory>{
                   new SubCategory(){
                       Name="84004 - Alpine",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="All Homes",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="New Construction",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="Forclosures",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="Land",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="Recently Sold",
                       Url="#"
                   }

                }
            },
            new TopMenu(){
                ParentMenuName = "Sell"
            },
            new TopMenu(){
                ParentMenuName="Mortgage"
            },
            new TopMenu(){
                ParentMenuName="Agents",
                SubCategories = new List<SubCategory>{
                   new SubCategory(){
                       Name="Looking for an Agent",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="Advertising Solutions",
                       Url="#"
                   },
                   new SubCategory(){
                       Name="Create Agent Profile",
                       Url="#"
                   }
                }
            }};

            return topMenu;
        }
    }
}
