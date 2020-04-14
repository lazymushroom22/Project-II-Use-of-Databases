using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRentalProject.DataAccess2
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(CarRentalProjectDbContext dbContext) : base(dbContext)
        {

        }
        public User GetUserByUserId(Guid userId)
        {
            return dbContext.User
                            .Where(User => User.UserId == userId)
                            .SingleOrDefault();
        }
    }
}
