using Nitrogen.Data.Mysql.Data;
using Nitrogen.ILogic.SystemILogic;
using Nitrogen.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nitrogen.Logic.SystemLogic
{
    public class PermissionsLogic: BaseLogic<Permissions>, PermissionsILogic
    {
        public PermissionsLogic(MySqlDbContext mySqlDbContext)
        {
            this._dbContext = mySqlDbContext;
        }
    }
}
