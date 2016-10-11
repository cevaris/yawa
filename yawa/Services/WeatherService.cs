using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using yawa.Models;

namespace yawa
{

	public interface IWeatherService
	{
		Task<List<WeatherHour>> RefreshDataAsync();

	}

	public class WeatherService : IWeatherService
	{
		HttpClient client;

		public WeatherService()
		{
			client = new HttpClient();
		}

		public Task<List<WeatherHour>> RefreshDataAsync()
		{
			throw new NotImplementedException();
		}
	}
}
