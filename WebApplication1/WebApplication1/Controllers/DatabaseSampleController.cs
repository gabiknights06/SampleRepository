using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySql.Data.MySqlClient;
using LibraryServices.Data.Interfaces;
using LibraryServices.Data.Models;
using LibraryServices.Data.Repositories;

namespace WebApplication1.Controllers
{
    public class DatabaseSampleController : ApiController
    {
        private iCityRepository city = new CityRepository();

        //public DatabaseSampleController(iCityRepository _city)
        //{
        //    this.city = _city;
        //}

        // GET: api/DatabaseSample
        public IEnumerable<City> Get()
        {
            return city.GetAllCity();
        }

        // GET: api/DatabaseSample/5
        public IHttpActionResult Get(int id)
        {
            var cityInfo = city.GetCity(id);
            if(cityInfo == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(cityInfo);
            }
            
        }

        // POST: api/DatabaseSample
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DatabaseSample/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DatabaseSample/5
        public void Delete(int id)
        {
        }
    }
}
