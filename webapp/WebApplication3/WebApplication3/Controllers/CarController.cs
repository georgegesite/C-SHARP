using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public static class GlobalList 
    { 
        public static List<CarModel> CarModelList { get; set; } = new List<CarModel>();

        public static int dummyCount = 5;
        public static int idCount = 0 + dummyCount;
        static GlobalList()
        {
            // Add dummy data to the CarModelList
            
            for (int i = 1; i <= dummyCount; i++)
            {
                CarModelList.Add(new CarModel
                {
                    Id = i,
                    Brand = $"Brand {i}",
                    Model = $"Model {i}"
                });
            }         
        }   
    }
    public class CarController : Controller
    {

        public IActionResult List(string searchItem)
        {
             if(searchItem == null)
            {
                return View(GlobalList.CarModelList);
            }
            else
            {
                var filteredCarModels = GlobalList.CarModelList
                     .Where(car => car.Brand.Equals(searchItem, StringComparison.OrdinalIgnoreCase) ||
                                   car.Model.Equals(searchItem, StringComparison.OrdinalIgnoreCase))
                     .ToList();

                if (filteredCarModels.Count != 0)
                {
                    return View(filteredCarModels);
                }
                else
                {
                    TempData["Message"] = "No matching objects found.";
                    return RedirectToAction("List");
                }
            }

        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult CreateAction(CarModel newCar)
        {
            newCar.Id = ++GlobalList.idCount;
            GlobalList.CarModelList.Add(newCar);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            var data = GlobalList.CarModelList.Find(carId => carId.Id == id );

            return View(data);
        }

        public IActionResult Edit(int id)
        {
            var carModel = GlobalList.CarModelList.Find(carId => carId.Id == id);

            if (carModel != null)
            {
                
                return View(carModel);
            }
            else
            {
       
                return NotFound();
            }
        }

        public IActionResult EditAction ( int id, CarModel param)
        {

            var carToUpdate = GlobalList.CarModelList.Find(carId => carId.Id == id);

            if (carToUpdate != null)
            {
                carToUpdate.Brand = param.Brand;
                carToUpdate.Model = param.Model;

                return RedirectToAction("List");
            }
            else
            {
                return NotFound(); 
            }
        }

        public IActionResult Delete(int id) 
        {
            var carToDelete = GlobalList.CarModelList.Find(carId => carId.Id == id);

            if (carToDelete != null)
            {
                GlobalList.CarModelList.Remove(carToDelete); 
                return RedirectToAction("List");
            }
            else
            {
                return NotFound(); 
            }
        }
        public IActionResult Search(string searchItem)
        {
            return RedirectToAction("List", new { searchItem });
        }




    }
}
