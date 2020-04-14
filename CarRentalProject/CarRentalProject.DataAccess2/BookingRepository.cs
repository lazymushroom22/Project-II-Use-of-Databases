using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.DataAccess2
{
    public class BookingRepository : BaseRepository<Booking>, iBookingRepository
    {
        public BookingRepository(CarRentalProjectDbContext dbContext) : base(dbContext)
        {

        }
        public CarDetails GetCarDetails(Guid carId, Car car)
        {
            CarDetails Carinfo = null;
            var selectedCar = dbContext.Car
                                       .Where(car => car.Id == carId)
                                       .SingleOrDefault();
                                       
            if(selectedCar != null)
            {
                  Carinfo = selectedCar.CarDetails
                           .Where(cardetail => cardetail.Car.Id == car.Id)
                           .SingleOrDefault();
            }
            return Carinfo;
        }
 
    }
}
