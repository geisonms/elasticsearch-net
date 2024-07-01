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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch;

[JsonConverter(typeof(RetrieverConverter))]
public sealed partial class Retriever
{
	internal Retriever(string variantName, object variant)
	{
		if (variantName is null)
			throw new ArgumentNullException(nameof(variantName));
		if (variant is null)
			throw new ArgumentNullException(nameof(variant));
		if (string.IsNullOrWhiteSpace(variantName))
			throw new ArgumentException("Variant name must not be empty or whitespace.");
		VariantName = variantName;
		Variant = variant;
	}

	internal object Variant { get; }
	internal string VariantName { get; }

	public static Retriever Knn(Elastic.Clients.Elasticsearch.KnnRetriever knnRetriever) => new Retriever("knn", knnRetriever);
	public static Retriever Rrf(Elastic.Clients.Elasticsearch.RRFRetriever rRFRetriever) => new Retriever("rrf", rRFRetriever);
	public static Retriever Standard(Elastic.Clients.Elasticsearch.StandardRetriever standardRetriever) => new Retriever("standard", standardRetriever);

	public bool TryGet<T>([NotNullWhen(true)] out T? result) where T : class
	{
		result = default;
		if (Variant is T variant)
		{
			result = variant;
			return true;
		}

		return false;
	}
}

internal sealed partial class RetrieverConverter : JsonConverter<Retriever>
{
	public override Retriever Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
		{
			throw new JsonException("Expected start token.");
		}

		object? variantValue = default;
		string? variantNameValue = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token.");
			}

			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				throw new JsonException("Expected a property name token representing the name of an Elasticsearch field.");
			}

			var propertyName = reader.GetString();
			reader.Read();
			if (propertyName == "knn")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.KnnRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "rrf")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.RRFRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			if (propertyName == "standard")
			{
				variantValue = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.StandardRetriever?>(ref reader, options);
				variantNameValue = propertyName;
				continue;
			}

			throw new JsonException($"Unknown property name '{propertyName}' received while deserializing the 'Retriever' from the response.");
		}

		var result = new Retriever(variantNameValue, variantValue);
		return result;
	}

	public override void Write(Utf8JsonWriter writer, Retriever value, JsonSerializerOptions options)
	{
		writer.WriteStartObject();
		if (value.VariantName is not null && value.Variant is not null)
		{
			writer.WritePropertyName(value.VariantName);
			switch (value.VariantName)
			{
				case "knn":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.KnnRetriever>(writer, (Elastic.Clients.Elasticsearch.KnnRetriever)value.Variant, options);
					break;
				case "rrf":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.RRFRetriever>(writer, (Elastic.Clients.Elasticsearch.RRFRetriever)value.Variant, options);
					break;
				case "standard":
					JsonSerializer.Serialize<Elastic.Clients.Elasticsearch.StandardRetriever>(writer, (Elastic.Clients.Elasticsearch.StandardRetriever)value.Variant, options);
					break;
			}
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RetrieverDescriptor<TDocument> : SerializableDescriptor<RetrieverDescriptor<TDocument>>
{
	internal RetrieverDescriptor(Action<RetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RetrieverDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RetrieverDescriptor<TDocument> Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RetrieverDescriptor<TDocument> Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public RetrieverDescriptor<TDocument> Knn(Elastic.Clients.Elasticsearch.KnnRetriever knnRetriever) => Set(knnRetriever, "knn");
	public RetrieverDescriptor<TDocument> Knn(Action<Elastic.Clients.Elasticsearch.KnnRetrieverDescriptor<TDocument>> configure) => Set(configure, "knn");
	public RetrieverDescriptor<TDocument> Rrf(Elastic.Clients.Elasticsearch.RRFRetriever rRFRetriever) => Set(rRFRetriever, "rrf");
	public RetrieverDescriptor<TDocument> Rrf(Action<Elastic.Clients.Elasticsearch.RRFRetrieverDescriptor<TDocument>> configure) => Set(configure, "rrf");
	public RetrieverDescriptor<TDocument> Standard(Elastic.Clients.Elasticsearch.StandardRetriever standardRetriever) => Set(standardRetriever, "standard");
	public RetrieverDescriptor<TDocument> Standard(Action<Elastic.Clients.Elasticsearch.StandardRetrieverDescriptor<TDocument>> configure) => Set(configure, "standard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RetrieverDescriptor : SerializableDescriptor<RetrieverDescriptor>
{
	internal RetrieverDescriptor(Action<RetrieverDescriptor> configure) => configure.Invoke(this);

	public RetrieverDescriptor() : base()
	{
	}

	private bool ContainsVariant { get; set; }
	private string ContainedVariantName { get; set; }
	private object Variant { get; set; }
	private Descriptor Descriptor { get; set; }

	private RetrieverDescriptor Set<T>(Action<T> descriptorAction, string variantName) where T : Descriptor
	{
		ContainedVariantName = variantName;
		ContainsVariant = true;
		var descriptor = (T)Activator.CreateInstance(typeof(T), true);
		descriptorAction?.Invoke(descriptor);
		Descriptor = descriptor;
		return Self;
	}

	private RetrieverDescriptor Set(object variant, string variantName)
	{
		Variant = variant;
		ContainedVariantName = variantName;
		ContainsVariant = true;
		return Self;
	}

	public RetrieverDescriptor Knn(Elastic.Clients.Elasticsearch.KnnRetriever knnRetriever) => Set(knnRetriever, "knn");
	public RetrieverDescriptor Knn<TDocument>(Action<Elastic.Clients.Elasticsearch.KnnRetrieverDescriptor> configure) => Set(configure, "knn");
	public RetrieverDescriptor Rrf(Elastic.Clients.Elasticsearch.RRFRetriever rRFRetriever) => Set(rRFRetriever, "rrf");
	public RetrieverDescriptor Rrf<TDocument>(Action<Elastic.Clients.Elasticsearch.RRFRetrieverDescriptor> configure) => Set(configure, "rrf");
	public RetrieverDescriptor Standard(Elastic.Clients.Elasticsearch.StandardRetriever standardRetriever) => Set(standardRetriever, "standard");
	public RetrieverDescriptor Standard<TDocument>(Action<Elastic.Clients.Elasticsearch.StandardRetrieverDescriptor> configure) => Set(configure, "standard");

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(ContainedVariantName))
		{
			writer.WritePropertyName(ContainedVariantName);
			if (Variant is not null)
			{
				JsonSerializer.Serialize(writer, Variant, Variant.GetType(), options);
				writer.WriteEndObject();
				return;
			}

			JsonSerializer.Serialize(writer, Descriptor, Descriptor.GetType(), options);
		}

		writer.WriteEndObject();
	}
}