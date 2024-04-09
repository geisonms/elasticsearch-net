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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Analysis;

public sealed partial class LengthTokenFilter : ITokenFilter
{
	[JsonInclude, JsonPropertyName("max")]
	public int? Max { get; set; }
	[JsonInclude, JsonPropertyName("min")]
	public int? Min { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "length";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class LengthTokenFilterDescriptor : SerializableDescriptor<LengthTokenFilterDescriptor>, IBuildableDescriptor<LengthTokenFilter>
{
	internal LengthTokenFilterDescriptor(Action<LengthTokenFilterDescriptor> configure) => configure.Invoke(this);

	public LengthTokenFilterDescriptor() : base()
	{
	}

	private int? MaxValue { get; set; }
	private int? MinValue { get; set; }
	private string? VersionValue { get; set; }

	public LengthTokenFilterDescriptor Max(int? max)
	{
		MaxValue = max;
		return Self;
	}

	public LengthTokenFilterDescriptor Min(int? min)
	{
		MinValue = min;
		return Self;
	}

	public LengthTokenFilterDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxValue.HasValue)
		{
			writer.WritePropertyName("max");
			writer.WriteNumberValue(MaxValue.Value);
		}

		if (MinValue.HasValue)
		{
			writer.WritePropertyName("min");
			writer.WriteNumberValue(MinValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("length");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	LengthTokenFilter IBuildableDescriptor<LengthTokenFilter>.Build() => new()
	{
		Max = MaxValue,
		Min = MinValue,
		Version = VersionValue
	};
}