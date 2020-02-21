using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IP_Project.Data.Repositories;
using IP_Project.Domain;
using IP_Project.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace IP_Project.Controllers
{
    [Controller]
    public class AreaController : Controller
    {
        private IAreaRepository _areaRepo;
        private IDimensionRepository _dimRepo;

        public AreaController(IAreaRepository areaRepo, IDimensionRepository dimRepo)
        {
            _areaRepo = areaRepo;
            _dimRepo = dimRepo;
        }

        [Route("Area/Index/{floor}")]
        public IActionResult Index(int floor)
        {
            MySqlConnection con = new MySqlConnection("host=sql7.freemysqlhosting.net;user=sql7323917;password=s1VSnVYe3w;database=sql7323917;");
            string sql = " SELECT area_number, area_amount FROM Camera  ";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            Dictionary<string, string> values = new Dictionary<string, string>();
            while (reader.Read())
            {
                string area_number = reader.GetString(0);
                string area_amount = reader.GetString(1);
                values.Add(area_number, area_amount);
            }

            foreach (KeyValuePair<string, string> entry in values)
            {
                Area area = _areaRepo.GetByAreaNumber(entry.Key);
                if (area != null)
                {
                    area.Amount = Convert.ToInt32(entry.Value);
                    _areaRepo.Update(area);
                }
                else
                {
                    area = new Area(entry.Key, Convert.ToInt32(entry.Value));
                    _areaRepo.Add(area);
                }
            }
            con.Close();
            _areaRepo.SaveChanges();

            FloorPlanViewModel vm = new FloorPlanViewModel();
            vm.Dimensions = _dimRepo.GetAll().Where(dim=>dim.Floor==floor).ToList();
            vm.Areas = _areaRepo.GetAll();
            vm.FloorId = floor;
            return View(vm);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            FloorPlanViewModel vm = new FloorPlanViewModel();
            vm.DimensionsJson = JsonConvert.SerializeObject(_dimRepo.GetAll());
            return View(vm);
        }

        [HttpPost]
        public bool AddDimensions([FromBody]Dimension[] dimensions)
        {
            try
            {
                foreach (Dimension dim in dimensions)
                {
                    _dimRepo.Add(dim);
                }
                _dimRepo.SaveChanges();
            }
            catch(Exception e)
            {
                return false;
            }
            return true;
        }

        [HttpPost]
        public void DeleteDimension(long id)
        {
            Dimension dim = _dimRepo.GetById(id);
            _dimRepo.Delete(dim);
            _dimRepo.SaveChanges();
        }
        [HttpPost]
        public bool DeleteAllDimensions([FromBody] int floor)
        {
            try
            {
                _dimRepo.DeleteAll(floor);
                _dimRepo.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        [HttpPost]
        public void UpdateArea(UpdateArea update)
        {
            Area area = _areaRepo.GetAll().Where(a => a.AreaNumber == update.AreaNumber).FirstOrDefault();
            area.Amount = update.Amount;
            _areaRepo.Update(area);
            _areaRepo.SaveChanges();
        }

    }
}