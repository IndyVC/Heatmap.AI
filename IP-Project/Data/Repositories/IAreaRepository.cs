using IP_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Data.Repositories
{
    public interface IAreaRepository
    {
        void Add(Area area);
        void Update(Area area);
        List<Area> GetAll();
        Area GetById(long id);
        Area GetByAreaNumber(string areaNumber);
        void Delete(Area area);
        void SaveChanges();
    }
}
