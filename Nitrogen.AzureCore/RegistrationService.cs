using Microsoft.Extensions.DependencyInjection;
using Nitrogen.Foundation;
using Nitrogen.ILogic.SystemILogic;
using Nitrogen.Logic;
using Nitrogen.Logic.SystemLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nitrogen.AzureCore
{
    public class RegistrationService
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddTransient<VerifyCodeHelper, VerifyCodeHelper>();
            services.AddTransient<PermissionsCategoryILogic, PermissionsCategoryLogic>();
            services.AddTransient<PermissionsILogic, PermissionsLogic>();
            services.AddTransient<IAdministratorLogic, AdministratorLogic>();
        }
    }
}
