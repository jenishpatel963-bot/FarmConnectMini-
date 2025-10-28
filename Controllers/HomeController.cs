using Microsoft.AspNetCore.Mvc;
using FarmConnectMini.Models;
using FarmConnectMini.Controllers;
using System.Collections.Generic;

namespace FarmConnectMini.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Crop> crops = FarmerController.GetAllCrops();
            return View(crops);
        }
    }
}
