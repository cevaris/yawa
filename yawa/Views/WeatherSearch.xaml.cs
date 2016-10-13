using System;
using System.Diagnostics;
using Xamarin.Forms;
using yawa.Models.Geo;

namespace yawa
{
	public partial class WeatherSearch : ContentPage
	{
		private IGeoService geoService = new GeoService();

		public WeatherSearch()
		{
			InitializeComponent();

			this.BindingContext = new GeoLocationsViewModel();
		}

		async void EntryCompleted(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("completed - {0}", text));
			GeoLocationsViewModel geoLocations = await geoService.Search(text);
			Debug.WriteLine(geoLocations);
			this.BindingContext = geoLocations;
		}

		void EntryChanged(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("changed - {0}", text));
		}

		void GeoLocationTapped(object sender, EventArgs e)
		{
			Debug.WriteLine(sender);
			Debug.WriteLine(e);

			if (this.BindingContext != null)
			{
				var geoLocation = (GeoLocation)this.BindingContext;
				Debug.WriteLine(geoLocation);
			}

		}
	}

}
