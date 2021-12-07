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
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	internal sealed class WeightedAverageAggregationConverter : JsonConverter<WeightedAverageAggregation>
	{
		public override WeightedAverageAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "weighted_avg")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new WeightedAverageAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}
					}

					if (reader.ValueTextEquals("value"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue?>(ref reader, options);
						if (value is not null)
						{
							agg.Value = value;
						}
					}

					if (reader.ValueTextEquals("value_type"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.ValueType?>(ref reader, options);
						if (value is not null)
						{
							agg.ValueType = value;
						}
					}

					if (reader.ValueTextEquals("weight"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue?>(ref reader, options);
						if (value is not null)
						{
							agg.Weight = value;
						}
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, WeightedAverageAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("weighted_avg");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.Value is not null)
			{
				writer.WritePropertyName("value");
				JsonSerializer.Serialize(writer, value.Value, options);
			}

			if (value.ValueType is not null)
			{
				writer.WritePropertyName("value_type");
				JsonSerializer.Serialize(writer, value.ValueType, options);
			}

			if (value.Weight is not null)
			{
				writer.WritePropertyName("weight");
				JsonSerializer.Serialize(writer, value.Weight, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(WeightedAverageAggregationConverter))]
	public partial class WeightedAverageAggregation : Aggregations.AggregationBase
	{
		public WeightedAverageAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; set; }

		[JsonInclude]
		[JsonPropertyName("value")]
		public Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? Value { get; set; }

		[JsonInclude]
		[JsonPropertyName("value_type")]
		public Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueType { get; set; }

		[JsonInclude]
		[JsonPropertyName("weight")]
		public Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? Weight { get; set; }
	}

	public sealed partial class WeightedAverageAggregationDescriptor<T> : DescriptorBase<WeightedAverageAggregationDescriptor<T>>
	{
		public WeightedAverageAggregationDescriptor()
		{
		}

		internal WeightedAverageAggregationDescriptor(Action<WeightedAverageAggregationDescriptor<T>> configure) => configure.Invoke(this);
		internal string? FormatValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? ValueValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? WeightValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal WeightedAverageValueDescriptor<T> ValueDescriptor { get; private set; }

		internal WeightedAverageValueDescriptor<T> WeightDescriptor { get; private set; }

		internal Action<WeightedAverageValueDescriptor<T>> ValueDescriptorAction { get; private set; }

		internal Action<WeightedAverageValueDescriptor<T>> WeightDescriptorAction { get; private set; }

		public WeightedAverageAggregationDescriptor<T> Format(string? format) => Assign(format, (a, v) => a.FormatValue = v);
		public WeightedAverageAggregationDescriptor<T> Value(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? value)
		{
			ValueDescriptor = null;
			ValueDescriptorAction = null;
			return Assign(value, (a, v) => a.ValueValue = v);
		}

		public WeightedAverageAggregationDescriptor<T> Value(Aggregations.WeightedAverageValueDescriptor<T> descriptor)
		{
			ValueValue = null;
			ValueDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ValueDescriptor = v);
		}

		public WeightedAverageAggregationDescriptor<T> Value(Action<Aggregations.WeightedAverageValueDescriptor<T>> configure)
		{
			ValueValue = null;
			ValueDescriptorAction = null;
			return Assign(configure, (a, v) => a.ValueDescriptorAction = v);
		}

		public WeightedAverageAggregationDescriptor<T> ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType) => Assign(valueType, (a, v) => a.ValueTypeValue = v);
		public WeightedAverageAggregationDescriptor<T> Weight(Elastic.Clients.Elasticsearch.Aggregations.WeightedAverageValue? weight)
		{
			WeightDescriptor = null;
			WeightDescriptorAction = null;
			return Assign(weight, (a, v) => a.WeightValue = v);
		}

		public WeightedAverageAggregationDescriptor<T> Weight(Aggregations.WeightedAverageValueDescriptor<T> descriptor)
		{
			WeightValue = null;
			WeightDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.WeightDescriptor = v);
		}

		public WeightedAverageAggregationDescriptor<T> Weight(Action<Aggregations.WeightedAverageValueDescriptor<T>> configure)
		{
			WeightValue = null;
			WeightDescriptorAction = null;
			return Assign(configure, (a, v) => a.WeightDescriptorAction = v);
		}

		public WeightedAverageAggregationDescriptor<T> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("weighted_avg");
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (ValueDescriptor is not null)
			{
				writer.WritePropertyName("value");
				JsonSerializer.Serialize(writer, ValueDescriptor, options);
			}
			else if (ValueDescriptorAction is not null)
			{
				writer.WritePropertyName("value");
				JsonSerializer.Serialize(writer, new Aggregations.WeightedAverageValueDescriptor<T>(ValueDescriptorAction), options);
			}
			else if (ValueValue is not null)
			{
				writer.WritePropertyName("value");
				JsonSerializer.Serialize(writer, ValueValue, options);
			}

			if (ValueTypeValue is not null)
			{
				writer.WritePropertyName("value_type");
				JsonSerializer.Serialize(writer, ValueTypeValue, options);
			}

			if (WeightDescriptor is not null)
			{
				writer.WritePropertyName("weight");
				JsonSerializer.Serialize(writer, WeightDescriptor, options);
			}
			else if (WeightDescriptorAction is not null)
			{
				writer.WritePropertyName("weight");
				JsonSerializer.Serialize(writer, new Aggregations.WeightedAverageValueDescriptor<T>(WeightDescriptorAction), options);
			}
			else if (WeightValue is not null)
			{
				writer.WritePropertyName("weight");
				JsonSerializer.Serialize(writer, WeightValue, options);
			}

			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}