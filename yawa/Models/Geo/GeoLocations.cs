using System;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;

namespace yawa.Models.Geo
{
	public class Location
	{
		[JsonProperty("lat")]
		public float Lat { get; set; }

		[JsonProperty("lng")]
		public float Lng { get; set; }
	}

	public class SouthWest
	{
		[JsonProperty("lat")]
		public float Lat { get; set; }

		[JsonProperty("lng")]
		public float Lng { get; set; }
	}

	public class NorthEast
	{
		[JsonProperty("lat")]
		public float Lat { get; set; }

		[JsonProperty("lng")]
		public float Lng { get; set; }
	}

	public class ViewPort
	{
		[JsonProperty("northeast")]
		public NorthEast NorthEast { get; set; }

		[JsonProperty("southwest")]
		public SouthWest SouthWest { get; set; }
	}

	public class Bounds
	{
		[JsonProperty("northeast")]
		public NorthEast NorthEast { get; set; }

		[JsonProperty("southwest")]
		public SouthWest SouthWest { get; set; }
	}

	public class Geometry
	{
		[JsonProperty("bounds")]
		public Bounds Bounds { get; set; }

		[JsonProperty("location")]
		public Location Location { get; set; }

		[JsonProperty("location_type")]
		public string LocationType { get; set; }

		[JsonProperty("viewport")]
		public ViewPort ViewPort { get; set; }

		[JsonProperty("place_id")]
		public string PlaceId { get; set; }

		[JsonProperty("types")]
		public IList<string> Types { get; set; }
	}

	public class AddressComponents
	{
		[JsonProperty("long_name")]
		public string LongName { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }

		[JsonProperty("types")]
		public IList<string> Types { get; set; }

		public AddressComponents()
		{
		}
	}

	public class GeoLocationsResult
	{
		[JsonProperty("address_components")]
		public IList<AddressComponents> AddressComponents { get; set; }

		[JsonProperty("formatted_address")]
		public string FormattedAddress { get; set; }

		[JsonProperty("geometry")]
		public Geometry Geometry { get; set; }
	}

	public class GeoLocationsResults
	{
		[JsonProperty("results")]
		public IList<GeoLocationsResult> Results { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }
	}

	public class GeoLocation
	{
		public string Name { get; set; }
		public Location Location { get; set; }

	}

	public class GeoLocations
	{
		public readonly IList<GeoLocation> Locations = new List<GeoLocation>();

		public GeoLocations()
		{
		}

		public GeoLocations(GeoLocationsResults geoLocationResults)
		{
			foreach (var result in geoLocationResults.Results)
			{
				Debug.WriteLine(result.FormattedAddress);
				Locations.Add(
					new GeoLocation
					{
						Name = result.FormattedAddress,
						Location = result.Geometry.Location
					}
				);

			}
		}
	}
}
