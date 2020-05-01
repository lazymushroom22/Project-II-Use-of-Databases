using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Services
{
   public class BookingService
    {
        private iBookingRepository bookingRepository;
        public BookingService(iBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }
        public CarDetails GetCarDetails(Guid carId, Car car)
        {
            Guid carIdGuid = Guid.Empty;
            Car carGuid = null;

            var booking = bookingRepository.GetCarDetails(carIdGuid, carGuid);
            if (booking == null)
            {
                throw new EntityNotFoundException(carIdGuid);
            }

            return booking;
        }
        public Booking CreateBooking(string bookingId, string name, string description, User user, Car cars)
        {
            var booking = new Booking
            {
                Id = Guid.Parse(bookingId),
                Name = name,
                Description = description,
                User = user,
                Cars = cars,
            };
            bookingRepository.Add(booking);
            return booking;
        }
    }
}