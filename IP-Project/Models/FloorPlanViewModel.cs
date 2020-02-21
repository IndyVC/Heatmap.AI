using IP_Project.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IP_Project.Models
{
    public class FloorPlanViewModel
    {
        public string DimensionsJson { get; set; }
        public List<Dimension> Dimensions { get; set; }
        public List<Area> Areas { get; set; }
        public int FloorId { get; set; }

        public FloorPlanViewModel()
        {
            Areas = new List<Area>();
        }

        public FloorPlanViewModel(Area area):base()
        {
            Areas.Add(area);
        }
    }
}
