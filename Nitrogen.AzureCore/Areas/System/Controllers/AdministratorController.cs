using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nitrogen.AzureCore.Controllers;

namespace Nitrogen.AzureCore.Areas.System.Controllers
{
    [Area("System")]
    public class AdministratorController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}