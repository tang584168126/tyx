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
    public class FriendControllerTest
    {
        /// <summary>
        /// 测试已分组的情况
        /// </summary>
        [TestMethod]
        public void TestListFriends_Grouped()
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

        /// <summary>
        /// 测试未分组的情况
        /// </summary>
        [TestMethod]
        public void TestListFriends_UnGrouped()
        {
            FriendController friendController = new FriendController();

            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns("1");
            friendController.ControllerContext = mock.Object;

            //执行
            PartialViewResult result = (PartialViewResult)friendController.ListFriends(-1);
            //断言
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewBag.Friends);

        }

        /// <summary>
        /// 测试按姓名搜索当前用户的好友
        /// </summary>
        [TestMethod]
        public void TestSearchFriend()
        {
            FriendController friendController = new FriendController();

            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns("1");
            friendController.ControllerContext = mock.Object;

            //执行
            PartialViewResult result = (PartialViewResult)friendController.SearchFriend("");
            //断言
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);

        }


        /// <summary>
        /// 测试向当前登录用户添加好友关系
        /// </summary>
        [TestMethod]
        public void TestAddFriendRelation_ShouldBe_Failed()
        {
            FriendController friendController = new FriendController();

            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns("1");
            friendController.ControllerContext = mock.Object;

            //执行
            ContentResult result = (ContentResult)friendController.AddFriendRelation("add friend", 1);
            //断言
            Assert.IsNotNull(result);
            Assert.AreEqual(result.Content, "0");

        }

    }
}
