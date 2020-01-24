using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Nitrogen.AzureCore.Models;
using Nitrogen.ILogic.SystemILogic;

namespace Nitrogen.AzureCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PermissionsCategoryILogic _permissionsCategoryILogic;
        private readonly PermissionsILogic _permissionsILogic;
        // ILogger<HomeController> logger, PermissionsCategoryILogic CategoryILogic,
        public HomeController(PermissionsILogic permissionsILogic)
        {
            //_logger = logger;
            //_permissionsCategoryILogic = CategoryILogic;
            _permissionsILogic = permissionsILogic;
        }

        public IActionResult Index()
        {
            // 测试数据读取速度.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
           // var list = _permissionsCategoryILogic.GetList(c => true).ToList();
            stopwatch.Stop();
            var time = stopwatch.ElapsedMilliseconds + "ms";
            return View();
        }

        public IActionResult GetMenut()
        {
            var jsonData = new
            {
                authorizeMenu = _permissionsILogic.GetList(c => c.DeleteMark == false).ToList(),           //导航菜单
            };
            return Content(JsonConvert.SerializeObject(jsonData)); 

        }

        public IActionResult GetPermissionsList()
        {
            var authorizeMenu = _permissionsILogic.GetList(c => c.DeleteMark == false).ToList();        //导航菜单
            return Content(JsonConvert.SerializeObject(authorizeMenu));
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
