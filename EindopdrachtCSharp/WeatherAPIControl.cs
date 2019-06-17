using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindopdrachtCSharp
{
	class WeatherAPIControl
	{
		ApiResponseObject _currObject;
		public WeatherAPIControl(string apiKey, string locale)
		{
			_currObject = new ApiResponseObject();

			string resourceUrl = string.Format("data/2.5/weather?q={0}&units=metric", locale);

			var response = RestHelper.Get("http://api.openweathermap.org", resourceUrl, apiKey);
			_currObject = RestHelper.ConvertJsonToObject<ApiResponseObject>(response.Content);

			string temp = _currObject.main.temp.ToString();
		}

		public void Save()
		{
			//write _currObject to the database.
		}
	}
}
