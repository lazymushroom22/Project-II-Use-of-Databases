using CarRentalProject.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Abstractions
{
    public interface iCarRepository : IRepository<Car>
    {
        IEnumerable<Car> GetCars();
        IEnumerable<Car> GetCarsByBrand(string brand);
        IEnumerable<Car> GetCarsByPriceLowerThan(double price);
        IEnumerable<Car> SearchForCar(string name);

    }
}
