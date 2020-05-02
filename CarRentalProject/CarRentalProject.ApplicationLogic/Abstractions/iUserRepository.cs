using CarRentalProject.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Abstractions
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByUserId(Guid userId);
    }
}
