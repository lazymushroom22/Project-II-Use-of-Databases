using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
    public class CarDetails
    {
        public Guid Id { get; set; }
        public Car Car { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }

        // MULTITUDE OF CAR FEATURES -- COULD BE ADDED

    }
}
