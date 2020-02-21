using IP_Project.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data.Mappers
{
    public class DimensionConfiguration : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.ToTable("Dimensions");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.AreaNumber);
            builder.Property(t => t.Width);
            builder.Property(t => t.Height);

        }
    }
}
