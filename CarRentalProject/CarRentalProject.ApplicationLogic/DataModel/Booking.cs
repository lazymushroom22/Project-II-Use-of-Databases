using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
   public class Booking
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public User User { get; set; }
        public Car Cars { get; set; }
        public ICollection<CarDetails> CarDetails { get; private set; }
        public ICollection<Testimonies> Testimonies { get; private set; }
    }
}
