using BulkyWeb.Data;
using BulkyWeb.Models;
using BulkyWeb.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;


namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CarController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CarController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var objCarList = _unitOfWork.Car.GetAll().ToList();
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
                _unitOfWork.Car.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index", "Car");
            }
            return View();
        }

        public IActionResult Edit(int? carId)
        {
            if (carId == null || carId == 0)
            {
                return NotFound();
            }
            Car? carFromDb = _unitOfWork.Car.Get(u => u.CarId == carId);
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
                _unitOfWork.Car.Update(obj);
                _unitOfWork.Save();
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
            Car? carFromDb = _unitOfWork.Car.Get(u => u.CarId == carId);
            if (carFromDb == null)
            {
                return NotFound();
            }
            return View(carFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? carId)
        {
            Car? obj = _unitOfWork.Car.Get(u => u.CarId == carId);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Car.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Category deleted successfully";
            return RedirectToAction("Index", "Car");


        }


    }


}

