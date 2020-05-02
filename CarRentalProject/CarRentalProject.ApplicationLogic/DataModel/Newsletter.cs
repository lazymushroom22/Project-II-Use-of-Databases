using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
    public class Newsletter
    {
        public Guid Id { get; set; }
        public Admin Admin { get; set; }
        public User User { get; set; }
        public string Comment { get; set; }
    }
}
