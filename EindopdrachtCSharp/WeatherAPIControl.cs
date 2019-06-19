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
		Weather _weather;
		EindopdrachtEntities db = new EindopdrachtEntities();
		public WeatherAPIControl(string apiKey, string locale)
		{
			_currObject = new ApiResponseObject();
			string resourceUrl = string.Format("data/2.5/weather?q={0}&units=metric", locale);

			var response = RestHelper.Get("http://api.openweathermap.org", resourceUrl, apiKey);
			_currObject = RestHelper.ConvertJsonToObject<ApiResponseObject>(response.Content);

		}

		/// <summary>
		/// takes the current stored item and saves it to the database, if empty nothing will happen.
		/// </summary>
		/// <returns>Current Object</returns>
		public void Save()
		{
			if (_currObject != null)
			{
				//write _currObject to the database.
				WeatherInfo newRecord = new WeatherInfo
				{
					Timestamp = DateTime.Now,
					Locale = _currObject.name,
					Country = _currObject.sys.country,
					Temperature = _currObject.main.temp.ToString(),
					Temperature_Min = _currObject.main.temp_min.ToString(),
					Temperature_Max = _currObject.main.temp_max.ToString()
				};

				_weather = _currObject.weather.FirstOrDefault();
				if (_weather != null)
				{
					newRecord.Description = _weather.description;
					newRecord.MainInfo = _weather.main;
				}

				db.WeatherInfoes.Add(newRecord);
				try
				{
					db.SaveChanges(); //in this case only crashes if the database is unreachable or if data is corrupted
				}
				catch (Exception e)
				{
					_currObject = null; //do this so that updatescreen doesnt die on error data
				}
			}			
		}

		/// <summary>
		/// Updates the Userinterface with either the current values or the most recent from the database.
		/// </summary>
		/// <returns></returns>
		public void UpdateScreen(MainScreen screen)
		{
			


			if (_currObject != null && _weather != null)
			{
				string currentTemp = "";
				if (screen.radio_celsius.Checked)
				{
					currentTemp = string.Format("{0} °C", _currObject.main.temp);
				}
				else
				{
					currentTemp = string.Format("{0} °F", ((9.0 / 5.0) * _currObject.main.temp + 32));
				}

				screen.weatherIcon.ImageLocation = "http://openweathermap.org/img/w/" + _weather.icon + ".png";
				screen.lblLocationActueel.Text = string.Format("{0}, {1}", _currObject.name, _currObject.sys.country);
				screen.lblWeatherInfoActueel.Text = _weather.main;
				screen.lblWeatherLongActueel.Text = _weather.description;
				screen.lblTemperatureActueel.Text = string.Format("{0}", currentTemp);
				screen.lblWindActueel.Text = string.Format("{0} met {1} km/h", calcDirection(_currObject.wind.deg), _currObject.wind.speed);
				screen.lblAirActueel.Text = string.Format("{0}%", _currObject.main.humidity);
				screen.contextMenuStrip1.Items[0].Text = "Temperatuur: " + currentTemp;
				//update the contect menu

				//set the last refresh date
				screen.lblLastUpdate.Text = string.Format("(Laatste update: {0})", DateTime.Now.ToLongTimeString());
			}
			else
			{
				//get the latest database values.
				WeatherInfo latestRecord = db.WeatherInfoes.LastOrDefault();	
				if(latestRecord != null)
				{
					string currentTemp = "";
					if (screen.radio_celsius.Checked)
					{
						currentTemp = string.Format("{0} °C", latestRecord.Temperature);
					}
					else
					{
						currentTemp = string.Format("{0} °F", ((9.0 / 5.0) * double.Parse(latestRecord.Temperature) + 32));
					}

					screen.lblLocationActueel.Text = string.Format("{0}, {1}", latestRecord.Locale, latestRecord.Country);
					screen.lblWeatherInfoActueel.Text = latestRecord.MainInfo;
					screen.lblWeatherLongActueel.Text = latestRecord.Description;
					screen.lblTemperatureActueel.Text = string.Format("{0}", currentTemp);
					screen.lblWindActueel.Text = "Unavailable";
					screen.lblAirActueel.Text = "Unavailable";
					screen.contextMenuStrip1.Items[0].Text = "Temperatuur: " + currentTemp;
				}
			}
		}

		private string calcDirection(int degree)
		{
			if (degree == 0)
			{
				return "N";
			}
			else if (degree == 90)
			{
				return "O";
			}
			else if (degree == 180)
			{
				return "Z";
			}
			else if (degree == 270)
			{
				return "W";
			}
			else if (degree > 0 && degree < 90)
			{
				return "NO";
			}
			else if (degree > 90 && degree < 180)
			{
				return "ZO";
			}
			else if (degree > 180 && degree < 270)
			{
				return "ZW";
			}
			else if (degree > 270)
			{
				return "NW";
			}
			else
			{
				return "Unkown";
			}
		}
	}
}
