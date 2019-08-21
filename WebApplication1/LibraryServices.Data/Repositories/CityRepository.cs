using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibraryServices.Data.Repositories
{
    public class CityRepository : ICityRepository
    {
        DatabaseConnector db = new DatabaseConnector();
        public List<City> GetAllCity()
        {
            List<City> cities = new List<City>();
            string sql_query = "Select * FROM city";
            db.query_cmd = new MySqlCommand(sql_query, db.conn);
            db.query_fetch = db.query_cmd.ExecuteReader();
            while (db.query_fetch.Read())
            {
                City data = new City();
                data.Id = Int32.Parse(db.query_fetch["ID"].ToString());
                data.Name = db.query_fetch["Name"].ToString();
                data.CountryCode = db.query_fetch["CountryCode"].ToString();
                data.District = db.query_fetch["District"].ToString();
                data.Population = db.query_fetch["Population"].ToString();
                cities.Add(data);
            }
            return cities;
        }
        public City GetCity(int Id)
        {
            List<City> cities = new List<City>();

            string sql_query = "Select * FROM city WHERE ID = " + Id;
            db.query_cmd = new MySqlCommand(sql_query, db.conn);
            db.query_fetch = db.query_cmd.ExecuteReader();
            while (db.query_fetch.Read())
            {
                City data = new City();
                data.Id = Int32.Parse(db.query_fetch["ID"].ToString());
                data.Name = db.query_fetch["Name"].ToString();
                data.CountryCode = db.query_fetch["CountryCode"].ToString();
                data.District = db.query_fetch["District"].ToString();
                data.Population = db.query_fetch["Population"].ToString();
                cities.Add(data);
            }
            var city = cities.FirstOrDefault(x => x.Id == Id);
            return city;
        }

        public void AddCity(City city)
        {
            string sql_query = "INSERT INTO city(Name, CountryCode, District, Population) VALUES(" +
                "'" + city.Name + "', " +
                "'" + city.CountryCode + "'," +
                "'" + city.District + "'," +
                "'" + city.Population + "')";
            db.query_cmd = new MySqlCommand(sql_query, db.conn);
            db.query_cmd.ExecuteNonQuery();
        }

        public void UpdateCity(City city)
        {
            string sql_query = "UPDATE city SET " +
                "Name = '" + city.Name + "'," +
                "CountryCode =  '" + city.CountryCode + "'," +
                "District =  '" + city.District + "'," +
                "Population =  '" + city.Population + "'" +
                "WHERE Id = " + city.Id;
            db.query_cmd = new MySqlCommand(sql_query, db.conn);
            db.query_cmd.ExecuteNonQuery();
        }

        public void DeleteCity(int Id)
        {
            string sql_query = "DELETE FROM city WHERE Id = " + Id;
            db.query_cmd = new MySqlCommand(sql_query, db.conn);
            db.query_cmd.ExecuteNonQuery();
        }
    }
}
