using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITest
{
    public class Helper
    {
       // private RestClient client;
        private RestRequest request;
        private const string baseUrl = "https://buggy.justtestit.org/";
        //private const Method post = Method.Post;

        public RestClient setUrl(string endpoint)
        {
            var url = Path.Combine(baseUrl, endpoint);
            var client = new RestClient(url);
            return client;
        }
        public RestRequest CreatePostRequest(string jsonString)
        {
            request = new RestRequest(Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", jsonString, ParameterType.RequestBody);
            return request;

        }
        public RestResponse GetResponse(RestClient restClient,RestRequest restRequest)
        {
            return restClient.Execute(restRequest);
        }
        public T GetContent<T>(RestResponse response)
        {
            var content = response.Content;
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
