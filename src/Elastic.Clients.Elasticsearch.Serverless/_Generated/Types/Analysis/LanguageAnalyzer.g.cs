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

public sealed partial class LanguageAnalyzer : IAnalyzer
{
	[JsonInclude, JsonPropertyName("language")]
	public Elastic.Clients.Elasticsearch.Serverless.Analysis.Language Language { get; set; }
	[JsonInclude, JsonPropertyName("stem_exclusion")]
	public ICollection<string> StemExclusion { get; set; }
	[JsonInclude, JsonPropertyName("stopwords")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string>? Stopwords { get; set; }
	[JsonInclude, JsonPropertyName("stopwords_path")]
	public string? StopwordsPath { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "language";

	[JsonInclude, JsonPropertyName("version")]
	public string? Version { get; set; }
}

public sealed partial class LanguageAnalyzerDescriptor : SerializableDescriptor<LanguageAnalyzerDescriptor>, IBuildableDescriptor<LanguageAnalyzer>
{
	internal LanguageAnalyzerDescriptor(Action<LanguageAnalyzerDescriptor> configure) => configure.Invoke(this);

	public LanguageAnalyzerDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Analysis.Language LanguageValue { get; set; }
	private ICollection<string> StemExclusionValue { get; set; }
	private ICollection<string>? StopwordsValue { get; set; }
	private string? StopwordsPathValue { get; set; }
	private string? VersionValue { get; set; }

	public LanguageAnalyzerDescriptor Language(Elastic.Clients.Elasticsearch.Serverless.Analysis.Language language)
	{
		LanguageValue = language;
		return Self;
	}

	public LanguageAnalyzerDescriptor StemExclusion(ICollection<string> stemExclusion)
	{
		StemExclusionValue = stemExclusion;
		return Self;
	}

	public LanguageAnalyzerDescriptor Stopwords(ICollection<string>? stopwords)
	{
		StopwordsValue = stopwords;
		return Self;
	}

	public LanguageAnalyzerDescriptor StopwordsPath(string? stopwordsPath)
	{
		StopwordsPathValue = stopwordsPath;
		return Self;
	}

	public LanguageAnalyzerDescriptor Version(string? version)
	{
		VersionValue = version;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("language");
		JsonSerializer.Serialize(writer, LanguageValue, options);
		writer.WritePropertyName("stem_exclusion");
		JsonSerializer.Serialize(writer, StemExclusionValue, options);
		if (StopwordsValue is not null)
		{
			writer.WritePropertyName("stopwords");
			SingleOrManySerializationHelper.Serialize<string>(StopwordsValue, writer, options);
		}

		if (!string.IsNullOrEmpty(StopwordsPathValue))
		{
			writer.WritePropertyName("stopwords_path");
			writer.WriteStringValue(StopwordsPathValue);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("language");
		if (!string.IsNullOrEmpty(VersionValue))
		{
			writer.WritePropertyName("version");
			writer.WriteStringValue(VersionValue);
		}

		writer.WriteEndObject();
	}

	LanguageAnalyzer IBuildableDescriptor<LanguageAnalyzer>.Build() => new()
	{
		Language = LanguageValue,
		StemExclusion = StemExclusionValue,
		Stopwords = StopwordsValue,
		StopwordsPath = StopwordsPathValue,
		Version = VersionValue
	};
}