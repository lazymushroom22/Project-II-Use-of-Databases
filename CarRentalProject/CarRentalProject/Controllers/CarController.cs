using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalProject.ApplicationLogic.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalProject.Controllers
{
    public class CarController : Controller
    {
        private readonly iCarRepository carRepository;

        public CarController(iCarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public ActionResult GetCars()
        {
            var cars = carRepository.GetCars();
            return View(cars);
        }

        public ActionResult GetCarsByBrand(string brand)
        {
            var cars = carRepository.GetCarsByBrand(brand);
            return View(cars);
        }

        public ActionResult GetCarsByPriceLowerThan(double price)
        {
            var cars = carRepository.GetCarsByPriceLowerThan(price);
            return View(cars);
        }

        public ActionResult SearchForCar(string name)
        {
            var cars = carRepository.SearchForCar(name);
            return View(cars);
        }
    }
}