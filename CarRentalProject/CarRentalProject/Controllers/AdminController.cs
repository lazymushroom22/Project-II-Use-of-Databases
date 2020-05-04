using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarRentalProject.ApplicationLogic.Services;
using CarRentalProject.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalProject.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly UserService userService;
        public AdminController(UserManager<IdentityUser> userManager, UserService userService)
        {
            this.userManager = userManager;
            this.userService = userService;

        }
        // GET: Admin
        public ActionResult Index()
        {
            try
            {
                var adminId = userManager.GetUserId(User);
                var admin = userService.GetUserbyUserId(adminId);         

                return View();
            }
            catch (Exception)
            {
                return BadRequest("Invalid request received ");
            }
        }

    }
}