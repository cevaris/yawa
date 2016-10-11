using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace yawa
{
	public partial class WeatherSearch : ContentPage
	{
		private IGeoService geoService = new GeoService();

		public WeatherSearch()
		{
			InitializeComponent();
		}

		async void EntryCompleted(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("completed - {0}", text));
			var geoLocations = await geoService.Search(text);
			Debug.WriteLine(geoLocations);
		}

		void EntryChanged(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("changed - {0}", text));
		}
	}

}
