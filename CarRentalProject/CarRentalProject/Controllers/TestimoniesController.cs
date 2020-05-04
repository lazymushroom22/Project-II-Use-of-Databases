using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalProject.ApplicationLogic.Services;
using CarRentalProject.DataAccess2;
using CarRentalProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalProject.Controllers
{
    public class TestimoniesController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserService userService;
        public TestimoniesController(UserManager<IdentityUser> userManager, UserService userService)
        {
            this.userManager = userManager;
            this.userService = userService;

        }
        // GET: Testimonies
        public ActionResult Index()
        {
            var machines = TestimoniesRepository.GetTestimonyDescription();
            return View();
        }

    }
}
