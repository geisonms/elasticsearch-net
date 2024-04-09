// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Core;
using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless;

/// <summary>
/// <para>A latitude/longitude as a 2 dimensional point. It can be represented in various ways:<br/>- as a `{lat, long}` object<br/>- as a geo hash value<br/>- as a `[lon, lat]` array<br/>- as a string in `"<lat>, <lon>"` or WKT point formats</para>
/// </summary>
[JsonConverter(typeof(GeoLocationConverter))]
public sealed partial class GeoLocation : IComplexUnion<GeoLocation.Kind>
{
	public enum Kind
	{
		LatitudeLongitude,
		Geohash,
		Coordinates,
		Text
	}

	private readonly Kind _kind;
	private readonly object _value;

	Kind IComplexUnion<Kind>.ValueKind => _kind;

	object IComplexUnion<Kind>.Value => _value;

	private GeoLocation(Kind kind, object value)
	{
		_kind = kind;
		_value = value;
	}

	public static GeoLocation LatitudeLongitude(Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation latitudeLongitude) => new(Kind.LatitudeLongitude, latitudeLongitude);

	public bool IsLatitudeLongitude => _kind == Kind.LatitudeLongitude;

	public bool TryGetLatitudeLongitude([NotNullWhen(true)] out Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation? latitudeLongitude)
	{
		latitudeLongitude = null;
		if (_kind == Kind.LatitudeLongitude)
		{
			latitudeLongitude = (Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation)_value;
			return true;
		}

		return false;
	}

	public static implicit operator GeoLocation(Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation latitudeLongitude) => GeoLocation.LatitudeLongitude(latitudeLongitude);

	public static GeoLocation Geohash(Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation geohash) => new(Kind.Geohash, geohash);

	public bool IsGeohash => _kind == Kind.Geohash;

	public bool TryGetGeohash([NotNullWhen(true)] out Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation? geohash)
	{
		geohash = null;
		if (_kind == Kind.Geohash)
		{
			geohash = (Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation)_value;
			return true;
		}

		return false;
	}

	public static implicit operator GeoLocation(Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation geohash) => GeoLocation.Geohash(geohash);

	public static GeoLocation Coordinates(double[] coordinates) => new(Kind.Coordinates, coordinates);

	public bool IsCoordinates => _kind == Kind.Coordinates;

	public bool TryGetCoordinates([NotNullWhen(true)] out double[]? coordinates)
	{
		coordinates = null;
		if (_kind == Kind.Coordinates)
		{
			coordinates = (double[])_value;
			return true;
		}

		return false;
	}

	public static implicit operator GeoLocation(double[] coordinates) => GeoLocation.Coordinates(coordinates);

	public static GeoLocation Text(string text) => new(Kind.Text, text);

	public bool IsText => _kind == Kind.Text;

	public bool TryGetText([NotNullWhen(true)] out string? text)
	{
		text = null;
		if (_kind == Kind.Text)
		{
			text = (string)_value;
			return true;
		}

		return false;
	}

	public static implicit operator GeoLocation(string text) => GeoLocation.Text(text);
}

internal sealed class GeoLocationConverter : MultiItemUnionConverter<GeoLocation, GeoLocation.Kind>
{
	public GeoLocationConverter()
	{
		_types = new Dictionary<GeoLocation.Kind, Type> { { GeoLocation.Kind.LatitudeLongitude, typeof(Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation) }, { GeoLocation.Kind.Geohash, typeof(Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation) } };
		_factories = new Dictionary<Type, Func<object, GeoLocation>> { { typeof(Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation), o => GeoLocation.LatitudeLongitude((Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation)o) }, { typeof(Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation), o => GeoLocation.Geohash((Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation)o) } };
		_uniquePropertyToType = new Dictionary<string, Type> { { "lat", typeof(Elastic.Clients.Elasticsearch.Serverless.LatLonGeoLocation) }, { "geohash", typeof(Elastic.Clients.Elasticsearch.Serverless.GeoHashLocation) } };
	}
}