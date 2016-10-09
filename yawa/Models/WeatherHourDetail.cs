using System;
namespace yawa.Models
{
	public class WeatherHourDetail
	{
		public WeatherHourDetail()
		{
		}

		public DateTime Hour { get; set; }
		public string HourText { get; }

		public int Temp { get; set; }
		public string TempText { get; }

		public int WindSpeed { get; set; }
		public string WindDirection { get; set; }
		public string WindText { get; }
	}
}
