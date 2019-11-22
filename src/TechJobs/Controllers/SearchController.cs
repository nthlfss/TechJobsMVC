using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        public IActionResult Results(string searchType, string searchTerm = "")
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            if (searchType.Equals("all"))
            {
                //use FindByValue passing in searchTerm and store the values in the list
                ViewBag.jobs = JobData.FindByValue(searchTerm);
            }
            else
            {
                //Use the searchTerm and the searchType and use the FindByColumnAndValue method and save that to the list
                ViewBag.jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            }

            return View("Index");
        }
    }
}


