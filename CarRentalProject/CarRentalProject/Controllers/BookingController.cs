using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalProject.Controllers
{
    public class BookingController : Controller
    {
        private readonly iBookingRepository bookingRepository;

        public BookingController(iBookingRepository bookingRepository)
        {
            this.bookingRepository = bookingRepository;
        }

        public ActionResult GetMachines()
        {
            Guid carIdGuid = Guid.Empty;
            Car carGuid = null;
            var cardetails = bookingRepository.GetCarDetails(carIdGuid, carGuid);
            return View(cardetails);
        }

    }
}