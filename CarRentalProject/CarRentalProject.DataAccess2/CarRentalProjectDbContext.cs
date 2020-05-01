using CarRentalProject.ApplicationLogic.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.DataAccess
{
    public class CarRentalProjectDbContext : DbContext
    {
        public CarRentalProjectDbContext(DbContextOptions<CarRentalProjectDbContext> options) : base(options)
        {
        }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<CarDetails> CarDetails { get; set; }
        public DbSet<Newsletter> Newsletter { get; set; }
        public DbSet<Testimonies> Testimonies { get; set; }

    }
}
