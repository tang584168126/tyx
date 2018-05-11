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
    public class PrivateGroupControllerTest
    {
        PrivateGroupController MockController()
        {
            var controller = new PrivateGroupController();
            var mock = new Mock<ControllerContext>();
            mock.Setup(p => p.HttpContext.User.Identity.Name).Returns("1");
            controller.ControllerContext = mock.Object;
            return controller;
        }


        /// <summary>
        /// 测试修改好友分组
        /// </summary>
        [TestMethod]
        public void TestChangeGroup_ShouldBe_Failed()
        {
            var controller = this.MockController();

            //执行
            ContentResult result = (ContentResult)controller.ChangeGroup(-2, 2);
            //断言
            Assert.IsNotNull(result);
            Assert.AreEqual("0", result.Content);

        }


        /// <summary>
        /// 测试删除好友分组
        /// </summary>
        [TestMethod]
        public void TestDeleteGroup_ShouldBe_Failed()
        {
            var controller = this.MockController();

            //执行
            ContentResult result = (ContentResult)controller.DeleteGroup(-1);
            //断言
            Assert.IsNotNull(result);
            Assert.AreEqual("0", result.Content);

        }


        /// <summary>
        /// 测试编辑好友分组
        /// </summary>
        [TestMethod]
        public void TestEditGroup()
        {
            var controller = this.MockController();

            //执行
            PartialViewResult result = (PartialViewResult)controller.EditGroup(4);
            //断言
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewBag.GroupId);
            Assert.IsNotNull(result.ViewBag.GroupName);

        }

        /// <summary>
        /// 测试修改(添加）好友分组
        /// </summary>
        [TestMethod]
        public void TestAddGroup_ShouldBe_Success()
        {
            var controller = this.MockController();

            //执行
            ContentResult result = (ContentResult)controller.EditGroup("Test分组", -1);
            //断言
            Assert.IsNotNull(result);
            Assert.AreEqual("1", result.Content);

        }

        /// <summary>
        /// 测试 获取当前用户所有分组信息
        /// </summary>
        [TestMethod]
        public void TestListGroups()
        {
            var controller = this.MockController();

            //执行
            PartialViewResult result = (PartialViewResult)controller.ListGroups();
            //断言
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ViewBag.groups);
            Assert.IsNotNull(result.ViewBag.unGroupCount);
            Assert.IsNotNull(result.ViewBag.TotalCount);
            Assert.AreEqual(result.ViewName, "GroupList");
        }


        /// <summary>
        /// 测试 获取当前用户所有分组信息
        /// </summary>
        [TestMethod]
        public void TestListGroupsToJson()
        {
            var controller = this.MockController();

            //执行
            JsonResult result = (JsonResult)controller.ListGroupsToJson();
            //断言
            Assert.IsNotNull(result);
           
        }

    }

}