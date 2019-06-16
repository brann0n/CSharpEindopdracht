using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindopdrachtCSharp
{
	public static class RestHelper
	{

		public static IRestResponse Post(string baseUrl, string resourceUrl, string json, string apiKey)
		{
			var client = new RestClient(baseUrl);
			var request = new RestRequest(resourceUrl, Method.POST);
			request.Timeout = 20 * 1000; //added extra timeout
			request.AddQueryParameter("APPID", apiKey);
			request.AddParameter("application/json", json, ParameterType.RequestBody);
			request.RequestFormat = DataFormat.Json;
			return client.Execute(request);
		}
		public static IRestResponse Get(string baseUrl, string resourceUrl, string apiKey)
		{
			var client = new RestClient(baseUrl);
			var request = new RestRequest(resourceUrl, Method.GET);
			request.Timeout = 20 * 1000; //added extra timeout
			request.AddQueryParameter("APPID", apiKey);			
			request.RequestFormat = DataFormat.Json;
			return client.Execute(request);
		}


		public static string ConvertObjectToJson(object arg)
		{
			return JsonConvert.SerializeObject(arg);
		}

		public static T ConvertJsonToObject<T>(string json)
		{
			return JsonConvert.DeserializeObject<T>(json);
		}
	}
}
