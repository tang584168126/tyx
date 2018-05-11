using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

using Friends.Controllers;
using System.Security.Principal;
using Moq;
using Friends.Web.Controllers;

namespace Friends.Web.Tests
{
    [TestClass]
    public class FriendControllerTest
    {
        [TestMethod]
        public void TestListFriends()
        {        
            FriendController friendController = new FriendController();

            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns("1");
            friendController.ControllerContext = mock.Object;

            //执行
            PartialViewResult result = (PartialViewResult)friendController.ListFriends(4);
            //断言
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewBag.Friends);
        }
    }
}
