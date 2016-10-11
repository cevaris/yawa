using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace yawa
{
	public partial class WeatherSearch : ContentPage
	{
		public WeatherSearch()
		{
			InitializeComponent();
		}

		void EntryCompleted(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("completed - {0}", text));
		}

		void EntryChanged(object sender, EventArgs e)
		{
			var text = ((Entry)sender).Text;
			Debug.WriteLine(String.Format("changed - {0}", text));
		}
	}

}
