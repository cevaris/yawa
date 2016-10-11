using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using yawa.Models;
using yawa.Models.Geo;
using yawa.Utils;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace yawa
{

	public interface IGeoService
	{
		Task<GeoLocations> Search(string address);
	}

	public class GeoService : IGeoService
	{
		private HttpClient client;

		public GeoService()
		{
			client = new HttpClient();
		}

		public async Task<GeoLocations> Search(string address)
		{
			var url = String.Format(
				"{0}?key={1}&address={2}",
				Constants.GoogleMapsGeoSearchUrl,Keys.GoogleMapsGeoKey,address
			);

			Debug.WriteLine(url);

			var response = await client.GetAsync(new Uri(url));
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				Debug.WriteLine(content);
				GeoLocationsResults geoLocationsResults = JsonConvert.DeserializeObject<GeoLocationsResults>(content);
				return new GeoLocations(geoLocationsResults);
			}
			else {
				var msg = String.Format(
					"failure querying for {0}: {1} {2}\n {3}",
					address, url, response.StatusCode, response.Content
				);
				Debug.WriteLine(msg);
				return new GeoLocations();
			}
		}
	}
}
