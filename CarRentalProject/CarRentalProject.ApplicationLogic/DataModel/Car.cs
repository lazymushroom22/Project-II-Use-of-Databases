using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string FuelType { get; set; }
        public double Price { get; set; }
        public bool Availability { get; set; }
        public ICollection<CarDetails> CarDetails { get; set; }
    }
}
