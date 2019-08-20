using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPIConsumer
{
    public class APICaller
    {
        string BaseURL;

        public APICaller()
        {
            BaseURL = "https://jsonplaceholder.typicode.com";
        }

        public IEnumerable<Post> GetAllToDo()
        {
            var client = new RestClient(BaseURL);

            var request = new RestRequest($@"{BaseURL}/todos");

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<IEnumerable<Post>> (response.Content);
        }

        public Post GetTodoById(int id)
        {
            var client = new RestClient(BaseURL);

            var request = new RestRequest($@"{BaseURL}/todos/{id}");

            var response = client.Execute(request);

            return JsonConvert.DeserializeObject<Post>(response.Content);
        }

        public void RegisterRecord(Post data)
        {
            var client = new RestClient(BaseURL);

            var request = new RestRequest($@"{BaseURL}/todos", Method.POST);

            request.AddParameter("Application/json", data, ParameterType.RequestBody);

            client.Execute(request);
        }

        public void RemoveRecord(Post data)
        {
            var client = new RestClient(BaseURL);

            var request = new RestRequest($@"{BaseURL}/todos", Method.DELETE);

            request.AddParameter("Application/json", data, ParameterType.RequestBody);

            client.Execute(request);
        }

    }
}
