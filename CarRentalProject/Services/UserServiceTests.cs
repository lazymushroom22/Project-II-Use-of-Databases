using CarRentalProject.ApplicationLogic.Abstractions;
using CarRentalProject.ApplicationLogic.DataModel;
using CarRentalProject.ApplicationLogic.Exceptions;
using CarRentalProject.ApplicationLogic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalProject.ApplicationLogic.Tests.Services
{

    [TestClass]
    public class UserServiceTests
    {
        private Mock<IUserRepository> UserRepoMock = new Mock<IUserRepository>();
        private Mock<iCarRepository> CarRepoMock = new Mock<iCarRepository>();
        private Guid UserId = Guid.Parse("7299FFCC-435E-4A6D-99DF-57A4D6FBA712");


        [TestInitialize]
        public void InitializeTest()
        {


            var user = new User
            {
                Id = UserId,
                Email = "andrei@clubpenguin.com",
                FirstName = "Andrei",
                LastName = "Belu",  
                UserId = UserId
            };

           UserRepoMock.Setup(userRepo => userRepo.GetUserByUserId(UserId))
                            .Returns(user);

        }

        [TestMethod]
        public void GetTeacherByUserId_ThrowsException_WhenUserIdHasInvalidValue()
        {
            //arrange
            var userService = new UserService(UserRepoMock.Object, CarRepoMock.Object);

            var badUserId = "jkajsdkasj dkj daksdj as";
            //act            
            //assert
            Assert.ThrowsException<Exception>(() => {
                userService.GetUserByUserId(UserId);
            });
        }

        [TestMethod]
        public void GetUserByUserId_ThrowsEntityNotFound_WhenUserDoesNotExist()
        {
            //arrange
            var userService = new UserService(UserRepoMock.Object, CarRepoMock.Object);

            //act            
            //assert
            Assert.ThrowsException<EntityNotFoundException>(() => {
                userService.GetUserByUserId(UserId);
            });
        }

        [TestMethod]
        public void GetUserByUserId_Returns_UserWhenExists()
        {

            Exception throwException = null;
            var userService = new UserService(UserRepoMock.Object, CarRepoMock.Object);
            User user = null;
            //act   
            try
            {
                
            }
            catch (Exception e)
            {
                throwException = e;
            }
            //assert
            Assert.IsNull(throwException, $"Exception was thrown");
            Assert.IsNotNull(user);
        }
    }
}