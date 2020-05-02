using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.DataAccess2
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        public AdminRepository(CarRentalProjectDbContext dbContext) : base(dbContext)
        {

        }
        public Admin GetAdminByAdminId(Guid adminId)
        {
            return dbContext.Admin
                            .Where(Admin => Admin.Id == adminId)
                            .SingleOrDefault();
        }
    }
}
