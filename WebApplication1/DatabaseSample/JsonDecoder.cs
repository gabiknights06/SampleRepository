using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Data.Models;

namespace DatabaseSample
{
    public class JsonDecoder 
    {
        public List<City> CityList(string jsonURL)
        {
            List<City> cities = new List<City>();
            City jsonParse = JsonConvert.DeserializeObject<City>(jsonURL);
            City city_data = new City();
            city_data.Name = jsonParse.Name;
            city_data.Id = jsonParse.Id;
            city_data.Population = jsonParse.Population;
            city_data.CountryCode = jsonParse.CountryCode;
            city_data.District = jsonParse.District;
            cities.Add(city_data);

            return cities;
        }
    }
}
