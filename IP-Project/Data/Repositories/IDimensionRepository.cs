using IP_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data.Repositories
{
    public interface IDimensionRepository
    {
        void Add(Dimension dim);
        void Update(Dimension dim);
        List<Dimension> GetAll();
        Dimension GetById(long id);
        void Delete(Dimension dim);
        void DeleteAll(int floor);
        void SaveChanges();
    }
}
