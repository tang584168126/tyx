using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

using Friends.Controllers;
using System.Security.Principal;
using Moq;

namespace Friends.Web.Tests
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void LoginGet()
        {
            // Arrange
            AccountController controller = new AccountController();

            // Act
            ViewResult result = (ViewResult)controller.LogIn();

            // Assert
            Assert.IsNotNull(result);
        }

    

        [TestMethod]
        public void TestSecurityCode()
        {
            //Arrange
            AccountController controller = new AccountController();

            FileContentResult result = (FileContentResult)controller.SecurityCode();

            Assert.IsNotNull(controller.TempData["SecurityCode"]);
            Assert.IsNotNull(result);

        }



    }


}
