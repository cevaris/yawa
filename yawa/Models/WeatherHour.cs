using System;
namespace yawa.Models
{
	public class WeatherHour
	{
		public WeatherHour()
		{
		}

		public DateTime Hour { get; set; }
		public string HourText
		{
			get
			{
				return Hour.ToLocalTime().ToString("HH tt");
			}
		}

		public int Temp { get; set; }
		public string TempText
		{
			get
			{
				return String.Format("{0}°", Temp.ToString());
			}
		}

		public int WindSpeed { get; set; }
		public string WindDirection { get; set; }
		public string WindText
		{
			get
			{
				return String.Format("{0} mph @ {1}", WindSpeed, WindDirection);
			}
		}
	}
}
