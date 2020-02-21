using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP_Project.Domain;
using Microsoft.EntityFrameworkCore;

namespace IP_Project.Data.Repositories
{
    public class DimensionRepository : IDimensionRepository
    {
        public ApplicationDbContext Context { get; }
        public DbSet<Dimension> Dimensions { get; }

        public DimensionRepository(ApplicationDbContext context)
        {
            Context = context;
            Dimensions = context.Dimensions;
        }

        public void Delete(Dimension dim)
        {
            Dimensions.Remove(dim);
        }

        public List<Dimension> GetAll()
        {
            return Dimensions.ToList();
        }

        public Dimension GetById(long id)
        {
            return Dimensions.Where(t => t.Id == id).FirstOrDefault();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Update(Dimension dim)
        {
            Dimensions.Update(dim);
        }

        public void Add(Dimension dim)
        {
            Dimensions.Add(dim);
        }

        public void DeleteAll(int floor)
        {
            Dimensions.RemoveRange(Dimensions.Where(dim=>dim.Floor==floor));
        }
    }
}
