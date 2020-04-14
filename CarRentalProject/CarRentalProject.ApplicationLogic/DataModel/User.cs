﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.DataModel
{
    public class User
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
