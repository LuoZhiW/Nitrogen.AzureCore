using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nitrogen.AzureCore.Controllers;
using Nitrogen.Foundation.Helper;
using Nitrogen.Foundation.Page;
using Nitrogen.ILogic.SystemILogic;

namespace Nitrogen.AzureCore.Areas.System.Controllers
{
    [Area("System")]
    public class AdministratorController : BaseController
    {
        private readonly IAdministratorLogic _administratorLogic;
        public AdministratorController(IAdministratorLogic administratorLogic)
        {
            _administratorLogic = administratorLogic;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取客户列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表Json</returns>
        [HttpGet]
        public IActionResult GetPageListJson(Pagination pagination, string queryJson)
        {
            var watch = CommonHelper.TimerStart();
            var data = _administratorLogic.FindList(c => true, pagination);
            var jsonData = new
            {
                rows = data,
                total = pagination.total,
                page = pagination.page,
                records = pagination.records,
                costtime = CommonHelper.TimerEnd(watch)
            };
            return ToJsonResult(jsonData);
        }
    }
}