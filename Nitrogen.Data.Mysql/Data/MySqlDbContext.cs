using Microsoft.EntityFrameworkCore;
using Nitrogen.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nitrogen.Data.Mysql.Data
{
    public class MySqlDbContext:DbContext
    {

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options) { }

        /// <summary>
        /// PermissionsCategory数据集.
        /// </summary>
        public DbSet<PermissionsCategory> PermissionsCategories { get; set; }

        /// <summary>
        /// Permissions数据集.
        /// </summary>
        public DbSet<Permissions> Permissions { get; set; }



    }
}
