using Microsoft.AspNetCore.Mvc;
using Moq;
using Newtonsoft.Json;
using Nitrogen.AzureCore.Controllers;
using Nitrogen.ILogic.SystemILogic;
using Nitrogen.Model;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace XUnit_Test
{
    /// <summary>
    /// 试用core下 XUnit 单元测试组件.
    /// </summary>
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {

        }


        [Fact]
        public void Home_GetMenutTest()
        {
            //var mockRepo = new Mock<PermissionsILogic>();
            //mockRepo.Setup(repo => repo.GetList(c => c.DeleteMark == false)).Returns(GetTestSessions);
            //var controller = new HomeController(mockRepo.Object);
            //var result = controller.GetMenut();
            //var viewResult = Assert.IsType<ContentResult>(result);
            //var model = Assert.IsAssignableFrom<string>(
            //    viewResult.Content);
            //// Console.WriteLine(viewResult.Content);
            //Assert.True(model.GetType() == typeof(string));
        }

        [Fact]
        public void Home_GetPermissionsList()
        {
            //var mockRepo = new Mock<PermissionsILogic>();
            //mockRepo.Setup(repo => repo.GetList(c => c.DeleteMark == false)).Returns(GetTestSessions);
            //var controller = new HomeController(mockRepo.Object);
            //var result = controller.GetPermissionsList();
            //var viewResult = Assert.IsType<ContentResult>(result);
            //var model = Assert.IsAssignableFrom<string>(viewResult.Content);
            //var list = JsonConvert.DeserializeObject<List<Permissions>>(model);
            //Assert.Equal(2, list.Count);
        }

        private IQueryable<Permissions> GetTestSessions()
        {
            var sessions = new List<Permissions>
            {
                new Permissions()
                {
                    PermissionName = "系统管理"
                },
                new Permissions()
                {
                    PermissionName = "学生管理"
                }
            };
            return  sessions.AsQueryable();
        }

    }
}
