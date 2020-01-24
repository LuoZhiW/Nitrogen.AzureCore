//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Nitrogen.AzureCore.Data
//{
//    public class DesignTimeDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
//    {
//        //ApplicationDbContext 代表的是你的创建失败的那个类型
//        public ApplicationDbContext CreateDbContext(string[] args)
//        {
//            IConfigurationRoot configuration = new ConfigurationBuilder()
//            .SetBasePath(Directory.GetCurrentDirectory())
//            .AddJsonFile("appsettings.json")
//            .Build();
//            var builder = new DbContextOptionsBuilder();
//            builder.UseMySql("Server=127.0.0.1,3306;uid=root;pwd=password;database=NitrogenCRM;charset=utf8;SslMode=None");
     
//            return new ApplicationDbContext(builder.Options);
//        }

//    }
//}
