using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryServices.Data.Models;
using LibraryServices.Data.Interfaces;
using Newtonsoft.Json;
using RestSharp;


namespace myRestAPI
{
    public class myAPIcaller : ICityRepository
    {
        string BaseURL = "";
        public myAPIcaller()
        {
            BaseURL = "http://localhost:58169";
        }

        public List<City> GetAllCity()
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest($@"{BaseURL}/api/DatabaseSample");
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<List<City>>(response.Content);
        }

        public City GetCity(int Id)
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest($@"{BaseURL}/api/DatabaseSample/{Id}");
            var response = client.Execute(request);
            return JsonConvert.DeserializeObject<City>(response.Content);
        }

        public void AddCity(City city)
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest($@"{BaseURL}/api/DatabaseSample", Method.POST);
            // request.AddParameter("application/json", city, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(city);
            client.Execute(request);
        }

        public void DeleteCity(int Id)
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest($@"{BaseURL}/api/DatabaseSample/{Id}", Method.DELETE);
            client.Execute(request);
        }

        public void UpdateCity(City city)
        {
            var client = new RestClient(BaseURL);
            var request = new RestRequest($@"{BaseURL}/api/DatabaseSample", Method.PUT);
            //request.AddParameter("application/json", city, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(city);
            client.Execute(request);
        }
    }
}
