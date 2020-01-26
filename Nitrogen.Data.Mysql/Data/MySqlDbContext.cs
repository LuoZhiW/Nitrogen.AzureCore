using Microsoft.EntityFrameworkCore;
using Nitrogen.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public DbSet<Administrator> Administrators { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity(typeof(Administrator)).ToTable("AspNetUsers").HasKey(new string[] { "Id" });
        }

    }
}
