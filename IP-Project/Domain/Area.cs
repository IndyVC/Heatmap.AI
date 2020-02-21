using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Domain
{
    public class Area
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string AreaNumber { get; set; }

        public Area()
        {

        }

        public Area(string areaNumber, int amount)
        {
            AreaNumber = areaNumber;
            Amount = amount;
        }
    }
}
