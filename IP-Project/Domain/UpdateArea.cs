using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Domain
{
    public class UpdateArea
    {
        public int Amount { get; set; }
        public string AreaNumber { get; set; }

        public UpdateArea()
        {

        }

        public UpdateArea(int amount, string areaNumber)
        {
            Amount = amount;
            AreaNumber = areaNumber;
        }
    }
}
