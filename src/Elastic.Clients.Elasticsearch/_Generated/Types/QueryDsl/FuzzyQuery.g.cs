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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	internal sealed class FuzzyQueryConverter : FieldNameQueryConverterBase<FuzzyQuery>
	{
		internal override FuzzyQuery ReadInternal(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var variant = new FuzzyQuery();
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					var property = reader.GetString();
					if (property == "max_expansions")
					{
						variant.MaxExpansions = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "prefix_length")
					{
						variant.PrefixLength = JsonSerializer.Deserialize<int?>(ref reader, options);
						continue;
					}

					if (property == "rewrite")
					{
						variant.Rewrite = JsonSerializer.Deserialize<string?>(ref reader, options);
						continue;
					}

					if (property == "transpositions")
					{
						variant.Transpositions = JsonSerializer.Deserialize<bool?>(ref reader, options);
						continue;
					}

					if (property == "fuzziness")
					{
						variant.Fuzziness = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Fuzziness?>(ref reader, options);
						continue;
					}

					if (property == "value")
					{
						variant.Value = JsonSerializer.Deserialize<object>(ref reader, options);
						continue;
					}

					if (property == "boost")
					{
						variant.Boost = JsonSerializer.Deserialize<float?>(ref reader, options);
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

		internal override void WriteInternal(Utf8JsonWriter writer, FuzzyQuery value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.MaxExpansions.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(value.MaxExpansions.Value);
			}

			if (value.PrefixLength.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(value.PrefixLength.Value);
			}

			if (value.Rewrite is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, value.Rewrite, options);
			}

			if (value.Transpositions.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(value.Transpositions.Value);
			}

			if (value.Fuzziness is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, value.Fuzziness, options);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, value.Value, options);
			if (value.Boost.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(value.Boost.Value);
			}

			if (!string.IsNullOrEmpty(value.QueryName))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(value.QueryName);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(FuzzyQueryConverter))]
	public partial class FuzzyQuery : FieldNameQueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "fuzzy";
		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("rewrite")]
		public string? Rewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("transpositions")]
		public bool? Transpositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public object Value { get; set; }
	}

	public sealed partial class FuzzyQueryDescriptor<T> : FieldNameQueryDescriptorBase<FuzzyQueryDescriptor<T>, T>
	{
		public FuzzyQueryDescriptor()
		{
		}

		internal FuzzyQueryDescriptor(Action<FuzzyQueryDescriptor<T>> configure) => configure.Invoke(this);
		internal int? MaxExpansionsValue { get; private set; }

		internal int? PrefixLengthValue { get; private set; }

		internal string? RewriteValue { get; private set; }

		internal bool? TranspositionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; private set; }

		internal object ValueValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		public FuzzyQueryDescriptor<T> MaxExpansions(int? maxExpansions) => Assign(maxExpansions, (a, v) => a.MaxExpansionsValue = v);
		public FuzzyQueryDescriptor<T> PrefixLength(int? prefixLength) => Assign(prefixLength, (a, v) => a.PrefixLengthValue = v);
		public FuzzyQueryDescriptor<T> Rewrite(string? rewrite) => Assign(rewrite, (a, v) => a.RewriteValue = v);
		public FuzzyQueryDescriptor<T> Transpositions(bool? transpositions = true) => Assign(transpositions, (a, v) => a.TranspositionsValue = v);
		public FuzzyQueryDescriptor<T> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness) => Assign(fuzziness, (a, v) => a.FuzzinessValue = v);
		public FuzzyQueryDescriptor<T> Value(object value) => Assign(value, (a, v) => a.ValueValue = v);
		public FuzzyQueryDescriptor<T> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		public FuzzyQueryDescriptor<T> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WritePropertyName(settings.Inferrer.Field(_field));
			writer.WriteStartObject();
			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			if (RewriteValue is not null)
			{
				writer.WritePropertyName("rewrite");
				JsonSerializer.Serialize(writer, RewriteValue, options);
			}

			if (TranspositionsValue.HasValue)
			{
				writer.WritePropertyName("transpositions");
				writer.WriteBooleanValue(TranspositionsValue.Value);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			writer.WritePropertyName("value");
			JsonSerializer.Serialize(writer, ValueValue, options);
			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			writer.WriteEndObject();
		}
	}
}