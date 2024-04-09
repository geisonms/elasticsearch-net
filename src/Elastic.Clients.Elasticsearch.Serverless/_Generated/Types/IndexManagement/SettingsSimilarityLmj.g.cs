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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class SettingsSimilarityLmj : ISettingsSimilarity
{
	[JsonInclude, JsonPropertyName("lambda")]
	public double? Lambda { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "LMJelinekMercer";
}

public sealed partial class SettingsSimilarityLmjDescriptor : SerializableDescriptor<SettingsSimilarityLmjDescriptor>, IBuildableDescriptor<SettingsSimilarityLmj>
{
	internal SettingsSimilarityLmjDescriptor(Action<SettingsSimilarityLmjDescriptor> configure) => configure.Invoke(this);

	public SettingsSimilarityLmjDescriptor() : base()
	{
	}

	private double? LambdaValue { get; set; }

	public SettingsSimilarityLmjDescriptor Lambda(double? lambda)
	{
		LambdaValue = lambda;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (LambdaValue.HasValue)
		{
			writer.WritePropertyName("lambda");
			writer.WriteNumberValue(LambdaValue.Value);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("LMJelinekMercer");
		writer.WriteEndObject();
	}

	SettingsSimilarityLmj IBuildableDescriptor<SettingsSimilarityLmj>.Build() => new()
	{
		Lambda = LambdaValue
	};
}