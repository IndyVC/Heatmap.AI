using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Domain
{
    public class Dimension
    {
        public long Id { get; set; }
        public string AreaNumber { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public int Floor { get; set; }

        public Dimension()
        {

        }

        public Dimension(string areaNumber, string width, string height, int floor)
        { 
            AreaNumber = areaNumber;
            Width = width;
            Height = height;
            Floor = floor;
        }
    }
}
