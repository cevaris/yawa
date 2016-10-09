using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using yawa.Models;


namespace yawa
{
	public partial class YamlMain : ContentPage
	{

		ObservableCollection<WeatherHourDetail> weatherHourDetails = new ObservableCollection<WeatherHourDetail>();

		public YamlMain()
		{
			weatherHourDetails.Add(new WeatherHourDetail { 
				Hour = DateTime.UtcNow,
				Temp = 999,
				WindSpeed = 999,
				WindDirection = "NW"
			});


			InitializeComponent();
		}
	}
}
