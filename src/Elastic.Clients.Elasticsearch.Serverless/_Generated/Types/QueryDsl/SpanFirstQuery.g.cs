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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class SpanFirstQuery
{
	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>Controls the maximum end position permitted in a match.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("end")]
	public int End { get; set; }

	/// <summary>
	/// <para>Can be any other span type query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("match")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery Match { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(SpanFirstQuery spanFirstQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.SpanFirst(spanFirstQuery);
	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery(SpanFirstQuery spanFirstQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery.SpanFirst(spanFirstQuery);
}

public sealed partial class SpanFirstQueryDescriptor<TDocument> : SerializableDescriptor<SpanFirstQueryDescriptor<TDocument>>
{
	internal SpanFirstQueryDescriptor(Action<SpanFirstQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public SpanFirstQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int EndValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery MatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor<TDocument> MatchDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor<TDocument>> MatchDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public SpanFirstQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Controls the maximum end position permitted in a match.</para>
	/// </summary>
	public SpanFirstQueryDescriptor<TDocument> End(int end)
	{
		EndValue = end;
		return Self;
	}

	/// <summary>
	/// <para>Can be any other span type query.</para>
	/// </summary>
	public SpanFirstQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public SpanFirstQueryDescriptor<TDocument> Match(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor<TDocument> descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public SpanFirstQueryDescriptor<TDocument> Match(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor<TDocument>> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public SpanFirstQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("end");
		writer.WriteNumberValue(EndValue);
		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor<TDocument>(MatchDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class SpanFirstQueryDescriptor : SerializableDescriptor<SpanFirstQueryDescriptor>
{
	internal SpanFirstQueryDescriptor(Action<SpanFirstQueryDescriptor> configure) => configure.Invoke(this);

	public SpanFirstQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private int EndValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery MatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor MatchDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor> MatchDescriptorAction { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public SpanFirstQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>Controls the maximum end position permitted in a match.</para>
	/// </summary>
	public SpanFirstQueryDescriptor End(int end)
	{
		EndValue = end;
		return Self;
	}

	/// <summary>
	/// <para>Can be any other span type query.</para>
	/// </summary>
	public SpanFirstQueryDescriptor Match(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQuery match)
	{
		MatchDescriptor = null;
		MatchDescriptorAction = null;
		MatchValue = match;
		return Self;
	}

	public SpanFirstQueryDescriptor Match(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor descriptor)
	{
		MatchValue = null;
		MatchDescriptorAction = null;
		MatchDescriptor = descriptor;
		return Self;
	}

	public SpanFirstQueryDescriptor Match(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor> configure)
	{
		MatchValue = null;
		MatchDescriptor = null;
		MatchDescriptorAction = configure;
		return Self;
	}

	public SpanFirstQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("end");
		writer.WriteNumberValue(EndValue);
		if (MatchDescriptor is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchDescriptor, options);
		}
		else if (MatchDescriptorAction is not null)
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.SpanQueryDescriptor(MatchDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("match");
			JsonSerializer.Serialize(writer, MatchValue, options);
		}

		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
	}
}