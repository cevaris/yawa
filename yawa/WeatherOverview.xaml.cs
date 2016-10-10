using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using yawa.Models;


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

		void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			App.Navigation.PushAsync(new MyCustomContentPage());
			
		}

	}
}
