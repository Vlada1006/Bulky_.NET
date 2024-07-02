using BulkyWeb.Data;
using BulkyWeb.Models;
using Microsoft.AspNetCore.Mvc;


namespace BulkyWeb.Controllers
{
    public class CarController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CarController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objCarList = _db.Cars.ToList();
            return View(objCarList);
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cars.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index", "Car");
            }
            return View();
        }

        public IActionResult Edit(int? carId)
        {
            if(carId == null || carId == 0)
            {
                return NotFound();
            }
            Car? carFromDb = _db.Cars.Find(carId);
            if (carFromDb == null)
            {
                return NotFound();
            }
            return View(carFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Car obj)
        {
            if (ModelState.IsValid)
            {
                _db.Cars.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToAction("Index", "Car");
            }
            return View();
        }

        public IActionResult Delete(int? carId)
        {
            if (carId == null || carId == 0)
            {
                return NotFound();
            }
            Car? carFromDb = _db.Cars.Find(carId);
            if (carFromDb == null)
            {
                return NotFound();
            }
            return View(carFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? carId)
        {
            Car? obj = _db.Cars.Find(carId);

            if(obj == null)
            {
                return NotFound();
            }

            _db.Cars.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Car");

           
        }


    }


}

