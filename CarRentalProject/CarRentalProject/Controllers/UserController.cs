using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalProject.ApplicationLogic.Services;
using CarRentalProject.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalProject.Controllers
{
    //[Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserService userService;
        public UserController(UserManager<IdentityUser> userManager, UserService userService)
        {
            this.userManager = userManager;
            this.userService = userService;

        }
        // GET: User
        public ActionResult Index()
        {
            try
            {
                var userId = userManager.GetUserId(User);
                var user = userService.GettUserbyUserId(userId);
                var userBookings = userService.GetUserBookings(userId);

                return View(new UserBookingViewModel { User = user, Bookings = userBookings });
            }
            catch (Exception)
            {
                return BadRequest("Invalid request received ");
            }
        }

    }
}