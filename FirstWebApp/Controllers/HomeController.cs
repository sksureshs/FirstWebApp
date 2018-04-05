using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;
using FirstWebApp.Models.Search;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Search()
        {
            var searchModel = new SearchViewModel
            {
                PickUpLocations = new List<SearchPickupLocationViewModel>
                {
                    new SearchPickupLocationViewModel
                    {
                        Id = 1,
                        Title = "Coimbatore",
                    },
                    new SearchPickupLocationViewModel
                    {
                        Id = 2,
                        Title = "Bangalore",
                    },
                    new SearchPickupLocationViewModel
                    {
                        Id = 3,
                        Title = "Chennai",
                    },
                    new SearchPickupLocationViewModel
                    {
                        Id = 4,
                        Title = "Erode",
                    },
                }

            };
            return View(searchModel);
        }

        [HttpPost]
        public IActionResult SearchResult(int selectedLocationId)
        {
            var results = new List<SearchResultViewModel>
            {
                new SearchResultViewModel
                {
                    FromTime = DateTime.Now,
                    ToTime = DateTime.Now.AddDays(3),
                    AvailableLocations = new List<string>
                    {
                        "Airport",
                        "Central Bus Stand",
                        "Railway Station"
                    },
                    CarId = 1,
                    ImgUrl = @"\images\carspic\Polo.jpg",
                    Name = "VW Polo"
                },
                new SearchResultViewModel
                {
                    FromTime = DateTime.Now,
                    ToTime = DateTime.Now.AddDays(3),
                    AvailableLocations = new List<string>
                    {
                        "Airport",
                        "Railway Station"
                    },
                    CarId = 1,
                    ImgUrl = @"\images\carspic\Octi_Vrs.jpg",
                    Name = "Skoda Octavia VRS"

                }
            };
            return View(results);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
