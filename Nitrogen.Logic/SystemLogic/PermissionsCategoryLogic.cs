using Nitrogen.Data.Mysql.Data;
using Nitrogen.ILogic.SystemILogic;
using Nitrogen.Model;

namespace Nitrogen.Logic
{
    /// <summary>
    /// 
    /// </summary>
    public class PermissionsCategoryLogic : BaseLogic<PermissionsCategory>, PermissionsCategoryILogic
    {
        public PermissionsCategoryLogic(MySqlDbContext mySqlDbContext)
        {
            this._dbContext = mySqlDbContext;
        }
    }
}
