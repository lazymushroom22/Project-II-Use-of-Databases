using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
    public class Testimonies
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string TestimonyDescription { get; set; }
        public string Comment { get; set; }
    }
}
