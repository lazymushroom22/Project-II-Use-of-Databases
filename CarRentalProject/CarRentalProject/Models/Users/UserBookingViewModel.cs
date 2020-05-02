using CarRentalProject.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalProject.Models.Users
{
    public class UserBookingViewModel
    {
        public User User { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
    }
}
