using IP_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data
{
    public class DataInitializer
    {
        private readonly ApplicationDbContext context;

        public DataInitializer(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void InitializeAsync()
        {
            context.Database.EnsureDeleted();
            if (context.Database.EnsureCreated())
            {
                Area area = new Area("Income hall", 34);
                context.Areas.Add(area);
                context.SaveChanges();
            }
        }
    }
}
