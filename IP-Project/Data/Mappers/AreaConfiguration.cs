using IP_Project.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data.Mappers
{
    public class AreaConfiguration : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Areas");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title);
            builder.Property(t => t.Amount);
        }
    }
}
