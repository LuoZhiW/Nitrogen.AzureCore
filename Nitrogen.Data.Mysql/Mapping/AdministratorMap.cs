using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nitrogen.Model;
using System;

namespace Nitrogen.Data.Mysql.Mapping
{
    public class AdministratorMap : IEntityTypeConfiguration<Administrator>
    {
        public void Configure(EntityTypeBuilder<Administrator> builder)
        {
            builder.ToTable("AspNetUsers");
            builder.HasKey(c => c.Id);
        }
    }
}
