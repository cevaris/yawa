using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using yawa.Models;
using System.Diagnostics;

namespace yawa
{
	public partial class WeatherOverview : ContentPage
	{
		public ObservableCollection<WeatherHour> WeatherHours { get; set; }

		public WeatherOverview()
		{
			InitializeComponent();

			WeatherHours = new ObservableCollection<WeatherHour> {
				new WeatherHour
				{
					Hour = DateTime.UtcNow,
					Temp = 999,
					WindSpeed = 999,
					WindDirection = "NW"
				},
				new WeatherHour
				{
					Hour = DateTime.UtcNow.AddHours(1),
					Temp = 999,
					WindSpeed = 999,

					WindDirection = "NW"
				}
			};

			HourListView.ItemsSource = WeatherHours;
		}

		void OnTappedSearch(object sender, EventArgs args)
		{
			Debug.WriteLine("OnTappedSearch");
			Navigation.PushAsync(new WeatherSearch());
		}

		void OnTappedList(object sender, EventArgs args)
		{
			Debug.WriteLine("OnTappedList");
		}

	}
}
