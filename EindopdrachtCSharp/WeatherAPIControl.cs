using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindopdrachtCSharp
{
	class WeatherAPIControl
	{
		public WeatherAPIControl(string apiKey)
		{
			
			var response = RestHelper.Get("http://api.openweathermap.org", "data/2.5/weather?q=Emmen,nl&units=metric", apiKey);
			ApiResponseObject rObject = RestHelper.ConvertJsonToObject<ApiResponseObject>(response.Content);

			string temp = rObject.main.temp.ToString();
		}
	}
}
