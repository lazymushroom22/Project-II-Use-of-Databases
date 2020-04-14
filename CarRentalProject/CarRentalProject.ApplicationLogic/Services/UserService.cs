using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Services
{
    public class UserService
    {
        private IUserRepository userRepository;
        private iBookingRepository bookingRepository;
        public UserService(IUserRepository userRepository, iBookingRepository bookingRepository)
        {
            this.userRepository = userRepository;
            this.bookingRepository = bookingRepository;
        }
        public User GettUserbyUserId(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid format.");
            }

            var user = userRepository.GetUserByUserId(userIdGuid);
            if (user == null)
            {
                throw new EntityNotFoundException(userIdGuid);
            }

            return user;
        }

        public IEnumerable<Booking> GetUserBookings(string userId)
        {
            Guid userIdGuid = Guid.Empty;
            if (!Guid.TryParse(userId, out userIdGuid))
            {
                throw new Exception("Invalid Guid format.");
            }

           return  bookingRepository.GetAll()
                             .Where(booking => booking.User.UserId == userIdGuid)
                             .AsEnumerable();
        }
    }
}
