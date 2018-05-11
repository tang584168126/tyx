using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList.Controllers
{

    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string desc { get; set; }
        public City(int id,string name)
        {
            this.Id =id;
            this.Name=name;
        }
    }

    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            List<City> cities = GetCities();
            SelectList list = new SelectList(cities, "Id", "Name", cities[1].Id);
            ViewBag.Cities = list;
            return View();
        }

        List<City> GetCities()
        {
            List<City> cities = new List<City>();
            cities.Add(new City(1, "北京"));
            cities.Add(new City(2, "上海"));
            cities.Add(new City(3, "天津"));
            cities.Add(new City(4, "重庆"));
            cities.Add(new City(5, "广州"));
            return cities;
        }




    }
}
