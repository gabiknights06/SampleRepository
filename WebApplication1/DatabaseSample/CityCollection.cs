using LibraryServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSample
{
    public class CityCollection
    {
        private List<City> cities;

        public List<City> Cities { get => cities; set => cities = value; }

        public List<City> GetCities()
        {
            return cities;
        }
    }
}
