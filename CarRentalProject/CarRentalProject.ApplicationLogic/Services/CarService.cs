using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Services
{
    public class CarService
    {
        private iCarRepository carRepository;

        public CarService(iCarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        public IEnumerable<Car> GetCarsByBrand(string brand)
        {
            var cars = carRepository.GetCarsByBrand(brand);

            Guid carIdGuid = Guid.Empty;

            if (cars == null)
            {
                throw new EntityNotFoundException(carIdGuid);
            }

            return cars;
        }

        public IEnumerable<Car> GetCarsByPriceLowerThan(double price)
        {
            var cars = carRepository.GetCarsByPriceLowerThan(price);

            Guid carIdGuid = Guid.Empty;

            if (cars == null)
            {
                throw new EntityNotFoundException(carIdGuid);
            }

            return cars;
        }

        public IEnumerable<Car> SearchForCar(string name)
        {
            var cars = carRepository.SearchForCar(name);

            Guid carIdGuid = Guid.Empty;

            if (cars == null)
            {
                throw new EntityNotFoundException(carIdGuid);
            }

            return cars;
        }

        public Car CreateCar(string carId, string name, string brand, string fueltype, double price)
        {
            var car = new Car
            {
                Id = Guid.Parse(carId),
                Name = name,
                Brand = brand,
                FuelType = fueltype,
                Price = price,
                Availability = true
            };
            carRepository.Add(car);
            return car;
        }
    }
}
