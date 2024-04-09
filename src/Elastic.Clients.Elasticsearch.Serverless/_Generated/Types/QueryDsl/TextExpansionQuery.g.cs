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

internal sealed partial class TextExpansionQueryConverter : JsonConverter<TextExpansionQuery>
{
	public override TextExpansionQuery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		reader.Read();
		var fieldName = reader.GetString();
		reader.Read();
		var variant = new TextExpansionQuery(fieldName);
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "boost")
				{
					variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
					continue;
				}

				if (property == "model_id")
				{
					variant.ModelId = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}

				if (property == "model_text")
				{
					variant.ModelText = JsonSerializer.Deserialize<string>(ref reader, options);
					continue;
				}

				if (property == "_name")
				{
					variant.QueryName = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}
			}
		}

		reader.Read();
		return variant;
	}

	public override void Write(Utf8JsonWriter writer, TextExpansionQuery value, JsonSerializerOptions options)
	{
		if (value.Field is null)
			throw new JsonException("Unable to serialize TextExpansionQuery because the `Field` property is not set. Field name queries must include a valid field name.");
		if (!options.TryGetClientSettings(out var settings))
			throw new JsonException("Unable to retrieve client settings required to infer field.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(value.Field));
		writer.WriteStartObject();
		if (value.Boost.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(value.Boost.Value);
		}

		writer.WritePropertyName("model_id");
		writer.WriteStringValue(value.ModelId);
		writer.WritePropertyName("model_text");
		writer.WriteStringValue(value.ModelText);
		if (!string.IsNullOrEmpty(value.QueryName))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(value.QueryName);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

[JsonConverter(typeof(TextExpansionQueryConverter))]
public sealed partial class TextExpansionQuery
{
	public TextExpansionQuery(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		if (field is null)
			throw new ArgumentNullException(nameof(field));
		Field = field;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public float? Boost { get; set; }
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>The text expansion NLP model to use</para>
	/// </summary>
	public string ModelId { get; set; }

	/// <summary>
	/// <para>The query text</para>
	/// </summary>
	public string ModelText { get; set; }
	public string? QueryName { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(TextExpansionQuery textExpansionQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.TextExpansion(textExpansionQuery);
}

public sealed partial class TextExpansionQueryDescriptor<TDocument> : SerializableDescriptor<TextExpansionQueryDescriptor<TDocument>>
{
	internal TextExpansionQueryDescriptor(Action<TextExpansionQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public TextExpansionQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string ModelIdValue { get; set; }
	private string ModelTextValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public TextExpansionQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TextExpansionQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TextExpansionQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TextExpansionQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The text expansion NLP model to use</para>
	/// </summary>
	public TextExpansionQueryDescriptor<TDocument> ModelId(string modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	/// <summary>
	/// <para>The query text</para>
	/// </summary>
	public TextExpansionQueryDescriptor<TDocument> ModelText(string modelText)
	{
		ModelTextValue = modelText;
		return Self;
	}

	public TextExpansionQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("model_id");
		writer.WriteStringValue(ModelIdValue);
		writer.WritePropertyName("model_text");
		writer.WriteStringValue(ModelTextValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}

public sealed partial class TextExpansionQueryDescriptor : SerializableDescriptor<TextExpansionQueryDescriptor>
{
	internal TextExpansionQueryDescriptor(Action<TextExpansionQueryDescriptor> configure) => configure.Invoke(this);

	public TextExpansionQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private string ModelIdValue { get; set; }
	private string ModelTextValue { get; set; }
	private string? QueryNameValue { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public TextExpansionQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	public TextExpansionQueryDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	public TextExpansionQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	public TextExpansionQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The text expansion NLP model to use</para>
	/// </summary>
	public TextExpansionQueryDescriptor ModelId(string modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	/// <summary>
	/// <para>The query text</para>
	/// </summary>
	public TextExpansionQueryDescriptor ModelText(string modelText)
	{
		ModelTextValue = modelText;
		return Self;
	}

	public TextExpansionQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		if (FieldValue is null)
			throw new JsonException("Unable to serialize field name query descriptor with a null field. Ensure you use a suitable descriptor constructor or call the Field method, passing a non-null value for the field argument.");
		writer.WriteStartObject();
		writer.WritePropertyName(settings.Inferrer.Field(FieldValue));
		writer.WriteStartObject();
		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		writer.WritePropertyName("model_id");
		writer.WriteStringValue(ModelIdValue);
		writer.WritePropertyName("model_text");
		writer.WriteStringValue(ModelTextValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		writer.WriteEndObject();
		writer.WriteEndObject();
	}
}