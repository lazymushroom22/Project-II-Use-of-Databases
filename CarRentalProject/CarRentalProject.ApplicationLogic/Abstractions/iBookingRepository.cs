using CarRentalProject.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Abstractions
{
    public interface iBookingRepository : IRepository<Booking>
    {
        CarDetails GetCarDetails(Guid carId, Car car);
    }
}
