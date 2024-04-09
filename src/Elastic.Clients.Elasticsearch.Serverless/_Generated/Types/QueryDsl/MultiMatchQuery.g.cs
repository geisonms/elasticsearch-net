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

public sealed partial class MultiMatchQuery
{
	/// <summary>
	/// <para>Analyzer used to convert the text in the query value into tokens.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analyzer")]
	public string? Analyzer { get; set; }

	/// <summary>
	/// <para>If `true`, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("auto_generate_synonyms_phrase_query")]
	public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>The fields to be queried.<br/>Defaults to the `index.query.default_field` index settings, which in turn defaults to `*`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? Fields { get; set; }

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzziness")]
	public Elastic.Clients.Elasticsearch.Serverless.Fuzziness? Fuzziness { get; set; }

	/// <summary>
	/// <para>Method used to rewrite the query.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_rewrite")]
	public string? FuzzyRewrite { get; set; }

	/// <summary>
	/// <para>If `true`, edits for fuzzy matching include transpositions of two adjacent characters (for example, `ab` to `ba`).<br/>Can be applied to the term subqueries constructed for all terms but the final term.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fuzzy_transpositions")]
	public bool? FuzzyTranspositions { get; set; }

	/// <summary>
	/// <para>If `true`, format-based errors, such as providing a text query value for a numeric field, are ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("lenient")]
	public bool? Lenient { get; set; }

	/// <summary>
	/// <para>Maximum number of terms to which the query will expand.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_expansions")]
	public int? MaxExpansions { get; set; }

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("minimum_should_match")]
	public Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatch { get; set; }

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("operator")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Operator? Operator { get; set; }

	/// <summary>
	/// <para>Number of beginning characters left unchanged for fuzzy matching.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("prefix_length")]
	public int? PrefixLength { get; set; }

	/// <summary>
	/// <para>Text, number, boolean value or date you wish to find in the provided field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string Query { get; set; }
	[JsonInclude, JsonPropertyName("_name")]
	public string? QueryName { get; set; }

	/// <summary>
	/// <para>Maximum number of positions allowed between matching tokens.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("slop")]
	public int? Slop { get; set; }

	/// <summary>
	/// <para>Determines how scores for each per-term blended query and scores across groups are combined.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tie_breaker")]
	public double? TieBreaker { get; set; }

	/// <summary>
	/// <para>How `the` multi_match query is executed internally.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.TextQueryType? Type { get; set; }

	/// <summary>
	/// <para>Indicates whether no documents are returned if the `analyzer` removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("zero_terms_query")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(MultiMatchQuery multiMatchQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.MultiMatch(multiMatchQuery);
}

public sealed partial class MultiMatchQueryDescriptor<TDocument> : SerializableDescriptor<MultiMatchQueryDescriptor<TDocument>>
{
	internal MultiMatchQueryDescriptor(Action<MultiMatchQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiMatchQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fuzziness? FuzzinessValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Operator? OperatorValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private int? SlopValue { get; set; }
	private double? TieBreakerValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.TextQueryType? TypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

	/// <summary>
	/// <para>Analyzer used to convert the text in the query value into tokens.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The fields to be queried.<br/>Defaults to the `index.query.default_field` index settings, which in turn defaults to `*`.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Serverless.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>Method used to rewrite the query.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, edits for fuzzy matching include transpositions of two adjacent characters (for example, `ab` to `ba`).<br/>Can be applied to the term subqueries constructed for all terms but the final term.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, format-based errors, such as providing a text query value for a numeric field, are ignored.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of terms to which the query will expand.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Operator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged for fuzzy matching.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>Text, number, boolean value or date you wish to find in the provided field.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public MultiMatchQueryDescriptor<TDocument> QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of positions allowed between matching tokens.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Slop(int? slop)
	{
		SlopValue = slop;
		return Self;
	}

	/// <summary>
	/// <para>Determines how scores for each per-term blended query and scores across groups are combined.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> TieBreaker(double? tieBreaker)
	{
		TieBreakerValue = tieBreaker;
		return Self;
	}

	/// <summary>
	/// <para>How `the` multi_match query is executed internally.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.TextQueryType? type)
	{
		TypeValue = type;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether no documents are returned if the `analyzer` removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	public MultiMatchQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
	{
		ZeroTermsQueryValue = zeroTermsQuery;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
		{
			writer.WritePropertyName("auto_generate_synonyms_phrase_query");
			writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
		}

		if (!string.IsNullOrEmpty(FuzzyRewriteValue))
		{
			writer.WritePropertyName("fuzzy_rewrite");
			writer.WriteStringValue(FuzzyRewriteValue);
		}

		if (FuzzyTranspositionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_transpositions");
			writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
		}

		if (LenientValue.HasValue)
		{
			writer.WritePropertyName("lenient");
			writer.WriteBooleanValue(LenientValue.Value);
		}

		if (MaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("max_expansions");
			writer.WriteNumberValue(MaxExpansionsValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (OperatorValue is not null)
		{
			writer.WritePropertyName("operator");
			JsonSerializer.Serialize(writer, OperatorValue, options);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (SlopValue.HasValue)
		{
			writer.WritePropertyName("slop");
			writer.WriteNumberValue(SlopValue.Value);
		}

		if (TieBreakerValue.HasValue)
		{
			writer.WritePropertyName("tie_breaker");
			writer.WriteNumberValue(TieBreakerValue.Value);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		if (ZeroTermsQueryValue is not null)
		{
			writer.WritePropertyName("zero_terms_query");
			JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class MultiMatchQueryDescriptor : SerializableDescriptor<MultiMatchQueryDescriptor>
{
	internal MultiMatchQueryDescriptor(Action<MultiMatchQueryDescriptor> configure) => configure.Invoke(this);

	public MultiMatchQueryDescriptor() : base()
	{
	}

	private string? AnalyzerValue { get; set; }
	private bool? AutoGenerateSynonymsPhraseQueryValue { get; set; }
	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? FieldsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fuzziness? FuzzinessValue { get; set; }
	private string? FuzzyRewriteValue { get; set; }
	private bool? FuzzyTranspositionsValue { get; set; }
	private bool? LenientValue { get; set; }
	private int? MaxExpansionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? MinimumShouldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Operator? OperatorValue { get; set; }
	private int? PrefixLengthValue { get; set; }
	private string QueryValue { get; set; }
	private string? QueryNameValue { get; set; }
	private int? SlopValue { get; set; }
	private double? TieBreakerValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.TextQueryType? TypeValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; set; }

	/// <summary>
	/// <para>Analyzer used to convert the text in the query value into tokens.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Analyzer(string? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, match phrase queries are automatically created for multi-term synonyms.</para>
	/// </summary>
	public MultiMatchQueryDescriptor AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true)
	{
		AutoGenerateSynonymsPhraseQueryValue = autoGenerateSynonymsPhraseQuery;
		return Self;
	}

	/// <summary>
	/// <para>Floating point number used to decrease or increase the relevance scores of the query.<br/>Boost values are relative to the default value of 1.0.<br/>A boost value between 0 and 1.0 decreases the relevance score.<br/>A value greater than 1.0 increases the relevance score.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The fields to be queried.<br/>Defaults to the `index.query.default_field` index settings, which in turn defaults to `*`.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Fields(Elastic.Clients.Elasticsearch.Serverless.Fields? fields)
	{
		FieldsValue = fields;
		return Self;
	}

	/// <summary>
	/// <para>Maximum edit distance allowed for matching.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Fuzziness(Elastic.Clients.Elasticsearch.Serverless.Fuzziness? fuzziness)
	{
		FuzzinessValue = fuzziness;
		return Self;
	}

	/// <summary>
	/// <para>Method used to rewrite the query.</para>
	/// </summary>
	public MultiMatchQueryDescriptor FuzzyRewrite(string? fuzzyRewrite)
	{
		FuzzyRewriteValue = fuzzyRewrite;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, edits for fuzzy matching include transpositions of two adjacent characters (for example, `ab` to `ba`).<br/>Can be applied to the term subqueries constructed for all terms but the final term.</para>
	/// </summary>
	public MultiMatchQueryDescriptor FuzzyTranspositions(bool? fuzzyTranspositions = true)
	{
		FuzzyTranspositionsValue = fuzzyTranspositions;
		return Self;
	}

	/// <summary>
	/// <para>If `true`, format-based errors, such as providing a text query value for a numeric field, are ignored.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Lenient(bool? lenient = true)
	{
		LenientValue = lenient;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of terms to which the query will expand.</para>
	/// </summary>
	public MultiMatchQueryDescriptor MaxExpansions(int? maxExpansions)
	{
		MaxExpansionsValue = maxExpansions;
		return Self;
	}

	/// <summary>
	/// <para>Minimum number of clauses that must match for a document to be returned.</para>
	/// </summary>
	public MultiMatchQueryDescriptor MinimumShouldMatch(Elastic.Clients.Elasticsearch.Serverless.MinimumShouldMatch? minimumShouldMatch)
	{
		MinimumShouldMatchValue = minimumShouldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Boolean logic used to interpret text in the query value.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Operator(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Operator? value)
	{
		OperatorValue = value;
		return Self;
	}

	/// <summary>
	/// <para>Number of beginning characters left unchanged for fuzzy matching.</para>
	/// </summary>
	public MultiMatchQueryDescriptor PrefixLength(int? prefixLength)
	{
		PrefixLengthValue = prefixLength;
		return Self;
	}

	/// <summary>
	/// <para>Text, number, boolean value or date you wish to find in the provided field.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Query(string query)
	{
		QueryValue = query;
		return Self;
	}

	public MultiMatchQueryDescriptor QueryName(string? queryName)
	{
		QueryNameValue = queryName;
		return Self;
	}

	/// <summary>
	/// <para>Maximum number of positions allowed between matching tokens.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Slop(int? slop)
	{
		SlopValue = slop;
		return Self;
	}

	/// <summary>
	/// <para>Determines how scores for each per-term blended query and scores across groups are combined.</para>
	/// </summary>
	public MultiMatchQueryDescriptor TieBreaker(double? tieBreaker)
	{
		TieBreakerValue = tieBreaker;
		return Self;
	}

	/// <summary>
	/// <para>How `the` multi_match query is executed internally.</para>
	/// </summary>
	public MultiMatchQueryDescriptor Type(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.TextQueryType? type)
	{
		TypeValue = type;
		return Self;
	}

	/// <summary>
	/// <para>Indicates whether no documents are returned if the `analyzer` removes all tokens, such as when using a `stop` filter.</para>
	/// </summary>
	public MultiMatchQueryDescriptor ZeroTermsQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.ZeroTermsQuery? zeroTermsQuery)
	{
		ZeroTermsQueryValue = zeroTermsQuery;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(AnalyzerValue))
		{
			writer.WritePropertyName("analyzer");
			writer.WriteStringValue(AnalyzerValue);
		}

		if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
		{
			writer.WritePropertyName("auto_generate_synonyms_phrase_query");
			writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
		}

		if (BoostValue.HasValue)
		{
			writer.WritePropertyName("boost");
			writer.WriteNumberValue(BoostValue.Value);
		}

		if (FieldsValue is not null)
		{
			writer.WritePropertyName("fields");
			JsonSerializer.Serialize(writer, FieldsValue, options);
		}

		if (FuzzinessValue is not null)
		{
			writer.WritePropertyName("fuzziness");
			JsonSerializer.Serialize(writer, FuzzinessValue, options);
		}

		if (!string.IsNullOrEmpty(FuzzyRewriteValue))
		{
			writer.WritePropertyName("fuzzy_rewrite");
			writer.WriteStringValue(FuzzyRewriteValue);
		}

		if (FuzzyTranspositionsValue.HasValue)
		{
			writer.WritePropertyName("fuzzy_transpositions");
			writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
		}

		if (LenientValue.HasValue)
		{
			writer.WritePropertyName("lenient");
			writer.WriteBooleanValue(LenientValue.Value);
		}

		if (MaxExpansionsValue.HasValue)
		{
			writer.WritePropertyName("max_expansions");
			writer.WriteNumberValue(MaxExpansionsValue.Value);
		}

		if (MinimumShouldMatchValue is not null)
		{
			writer.WritePropertyName("minimum_should_match");
			JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
		}

		if (OperatorValue is not null)
		{
			writer.WritePropertyName("operator");
			JsonSerializer.Serialize(writer, OperatorValue, options);
		}

		if (PrefixLengthValue.HasValue)
		{
			writer.WritePropertyName("prefix_length");
			writer.WriteNumberValue(PrefixLengthValue.Value);
		}

		writer.WritePropertyName("query");
		writer.WriteStringValue(QueryValue);
		if (!string.IsNullOrEmpty(QueryNameValue))
		{
			writer.WritePropertyName("_name");
			writer.WriteStringValue(QueryNameValue);
		}

		if (SlopValue.HasValue)
		{
			writer.WritePropertyName("slop");
			writer.WriteNumberValue(SlopValue.Value);
		}

		if (TieBreakerValue.HasValue)
		{
			writer.WritePropertyName("tie_breaker");
			writer.WriteNumberValue(TieBreakerValue.Value);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		if (ZeroTermsQueryValue is not null)
		{
			writer.WritePropertyName("zero_terms_query");
			JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
		}

		writer.WriteEndObject();
	}
}