using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP_Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace IP_Project.Data.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        public ApplicationDbContext Context { get; }
        public DbSet<Area> Areas { get; }

        public AreaRepository(ApplicationDbContext context)
        {
            Context = context;
            Areas = context.Areas;
        }

        public void Delete(Area area)
        {
            Context.Remove(area);
        }

        public List<Area> GetAll()
        {
            return Areas.ToList();
        }

        public Area GetById(long id)
        {
            return Areas.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Update(Area area)
        {
            Areas.Update(area);
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Add(Area area)
        {
            Context.Add(area);
        }

        public Area GetByAreaNumber(string areaNumber)
        {
            return Areas.Where(a => a.AreaNumber == areaNumber).FirstOrDefault();
        }
    }
}
