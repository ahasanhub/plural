using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Globalmantics.DAL;
using Globalmantics.Logic;
using NUnit.Framework;

namespace Globalmantics.IntegrationTests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void CanCreateUser()
        {
            //Arrange 
            var context=new GlobalmanticsContext();
            var userService=new UserService(context);
            //Act
            var user = userService.GetUserByEmail("test@gmial.com");
            context.SaveChanges();
            //Assert
            user.UserId.Should().NotBe(0);
            user.Email.Should().Be("test@gmial.com");
        }
    }
}
