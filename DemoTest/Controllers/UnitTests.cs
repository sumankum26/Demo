using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Demo.Model;
using Demo.Controllers;
using Rhino.Mocks;
using Microsoft.Extensions.Logging;
using Assert = NUnit.Framework.Assert;

namespace DemoTest.Controllers
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void Get_WhenCalled_GetsCorrectNumberOfRecoreds()
        {
            var testUsers = GetallUser();
           
            //var logger = MockRepository.GenerateStub<ILogger<UserController>>();

            var controller = new UserController();
            var result = controller.Get() as List<User>;
            Assert.AreEqual(testUsers.Count, result.Count);
        }

        [TestMethod]
        public void Post_WhenCalled_SetsValuesCorrectly()
        {
            var testUsers = GetallUser();
            var user = new User { UserId = "1", FirstName = "Tom", LastName = "Cruise", Role = "Actor", Location = "New York", IsActive = true };

            var controller = new UserController();
            var result = controller.Post(user);
            Assert.Multiple(() =>
            {
                Assert.AreEqual(user.UserId, result.UserId);
                Assert.AreEqual(user.FirstName, result.FirstName);
                Assert.AreEqual(user.IsActive, result.IsActive);
                Assert.AreEqual(user.LastName, result.LastName);
                Assert.AreEqual(user.Location, result.Location);
                Assert.AreEqual(user.Role, result.Role);
            });
        }

        private List<User> GetallUser()
        {
            var testUsers = new List<User>
            {
                new User { UserId = "1", FirstName = "Tom", LastName = "Cruise", Role = "Actor", Location = "New York", IsActive = true },
                new User { UserId = "2", FirstName = "Chris", LastName = "Pratt", Role = "Actor", Location = "Virginia", IsActive = true },
                new User { UserId = "3", FirstName = "Jennifer ", LastName = "Aniston", Role = "Actress", Location = "California", IsActive = true },
                new User { UserId = "4", FirstName = "Ross", LastName = "Geller", Role = "Actor", Location = "New York", IsActive = true },
                new User { UserId = "5", FirstName = "Rachel", LastName = "Green", Role = "Actress", Location = "New York", IsActive = false }
             };
            return testUsers;
        }
    }
}
