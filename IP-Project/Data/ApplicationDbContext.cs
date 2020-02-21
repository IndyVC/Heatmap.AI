using IP_Project.Data.Mappers;
using IP_Project.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {

        public DbSet<Area> Areas { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AreaConfiguration());
            builder.ApplyConfiguration(new DimensionConfiguration());
        }
    }
}
