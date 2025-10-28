using Microsoft.AspNetCore.Mvc;
using FarmConnectMini.Models;
using System.Collections.Generic;
using System.Linq;

namespace FarmConnectMini.Controllers
{
    public class FarmerController : Controller
    {
        // Temporary in-memory storage
        private static List<Crop> Crops = new List<Crop>
        {
            new Crop { Id = 1, Name = "Wheat", Price = 2000, Quantity = 10 },
            new Crop { Id = 2, Name = "Rice", Price = 2500, Quantity = 8 }
        };

        // GET: Farmer Dashboard
        public IActionResult Index()
        {
            return View(Crops);
        }

        // GET: Add Crop
        public IActionResult AddCrop()
        {
            return View();
        }

        // POST: Add Crop
        [HttpPost]
        public IActionResult AddCrop(Crop crop)
        {
            if (ModelState.IsValid)
            {
                crop.Id = Crops.Count > 0 ? Crops.Max(c => c.Id) + 1 : 1;
                Crops.Add(crop);
                return RedirectToAction("Index");
            }
            return View(crop);
        }

        // POST: Delete Crop
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var crop = Crops.FirstOrDefault(c => c.Id == id);
            if (crop != null)
            {
                Crops.Remove(crop);
            }
            return RedirectToAction("Index");
        }

        // This lets the User page show crops
        public static List<Crop> GetAllCrops()
        {
            return Crops;
        }
    }
}
