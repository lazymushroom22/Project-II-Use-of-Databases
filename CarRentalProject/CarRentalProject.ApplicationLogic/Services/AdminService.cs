using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Services
{
    public class AdminService
    {
        private IAdminRepository adminRepository;
        private iBookingRepository bookingRepository;
        public AdminService(IAdminRepository adminRepository, iBookingRepository bookingRepository)
        {
            this.adminRepository = adminRepository;
            this.bookingRepository = bookingRepository;
        }
        public Admin GetAdminbyAdminId(string adminId)
        {
            Guid adminIdGuid = Guid.Empty;
            if (!Guid.TryParse(adminId, out adminIdGuid))
            {
                throw new Exception("Invalid Guid format.");
            }

            var admin = adminRepository.GetAdminByAdminId(adminIdGuid);
            if (admin == null)
            {
                throw new EntityNotFoundException(adminIdGuid);
            }

            return admin;
        }

        public Admin CreateAdmin(string adminId, string email)
        {
            var admin = new Admin
            {
                Id = Guid.Parse(adminId),
                Email = email,


            };
            adminRepository.Add(admin);
            return admin;
        }
    }
}
