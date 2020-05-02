using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.DataAccess2
{
    public class CarRepository : BaseRepository<Car>, iCarRepository
    {
        public CarRepository(CarRentalProjectDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Car> GetCars()
        {
            var cars = dbContext.Car.AsEnumerable();
            return cars;
        }

        public IEnumerable<Car> GetCarsByBrand(string brand)
        {
            var cars = dbContext.Car.Where(o => o.Brand == brand).AsEnumerable();
            return cars;
        }

        public IEnumerable<Car> GetCarsByPriceLowerThan(double price)
        {
            var cars = dbContext.Car.Where(o => o.Price <= price).AsEnumerable();
            return cars;
        }

        public IEnumerable<Car> SearchForCar(string name)
        {
            var cars = dbContext.Car.Where(o => o.Name == name).AsEnumerable();
            return cars;
        }
    }
}
