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

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Search;

public sealed partial class HighlightField
{
	[JsonInclude, JsonPropertyName("analyzer")]
	public Elastic.Clients.Elasticsearch.Serverless.Analysis.IAnalyzer? Analyzer { get; set; }

	/// <summary>
	/// <para>A string that contains each boundary character.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boundary_chars")]
	public string? BoundaryChars { get; set; }

	/// <summary>
	/// <para>How far to scan for boundary characters.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boundary_max_scan")]
	public int? BoundaryMaxScan { get; set; }

	/// <summary>
	/// <para>Specifies how to break the highlighted fragments: chars, sentence, or word.<br/>Only valid for the unified and fvh highlighters.<br/>Defaults to `sentence` for the `unified` highlighter. Defaults to `chars` for the `fvh` highlighter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boundary_scanner")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.BoundaryScanner? BoundaryScanner { get; set; }

	/// <summary>
	/// <para>Controls which locale is used to search for sentence and word boundaries.<br/>This parameter takes a form of a language tag, for example: `"en-US"`, `"fr-FR"`, `"ja-JP"`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boundary_scanner_locale")]
	public string? BoundaryScannerLocale { get; set; }

	/// <summary>
	/// <para>Specifies how text should be broken up in highlight snippets: `simple` or `span`.<br/>Only valid for the `plain` highlighter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fragmenter")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterFragmenter? Fragmenter { get; set; }
	[JsonInclude, JsonPropertyName("fragment_offset")]
	public int? FragmentOffset { get; set; }

	/// <summary>
	/// <para>The size of the highlighted fragment in characters.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("fragment_size")]
	public int? FragmentSize { get; set; }
	[JsonInclude, JsonPropertyName("highlight_filter")]
	public bool? HighlightFilter { get; set; }

	/// <summary>
	/// <para>Highlight matches for a query other than the search query.<br/>This is especially useful if you use a rescore query because those are not taken into account by highlighting by default.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("highlight_query")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? HighlightQuery { get; set; }
	[JsonInclude, JsonPropertyName("matched_fields")]
	[JsonConverter(typeof(SingleOrManyFieldsConverter))]
	public Elastic.Clients.Elasticsearch.Serverless.Fields? MatchedFields { get; set; }

	/// <summary>
	/// <para>If set to a non-negative value, highlighting stops at this defined maximum limit.<br/>The rest of the text is not processed, thus not highlighted and no error is returned<br/>The `max_analyzed_offset` query setting does not override the `index.highlight.max_analyzed_offset` setting, which prevails when it’s set to lower value than the query setting.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_analyzed_offset")]
	public int? MaxAnalyzedOffset { get; set; }
	[JsonInclude, JsonPropertyName("max_fragment_length")]
	public int? MaxFragmentLength { get; set; }

	/// <summary>
	/// <para>The amount of text you want to return from the beginning of the field if there are no matching fragments to highlight.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("no_match_size")]
	public int? NoMatchSize { get; set; }

	/// <summary>
	/// <para>The maximum number of fragments to return.<br/>If the number of fragments is set to `0`, no fragments are returned.<br/>Instead, the entire field contents are highlighted and returned.<br/>This can be handy when you need to highlight short texts such as a title or address, but fragmentation is not required.<br/>If `number_of_fragments` is `0`, `fragment_size` is ignored.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("number_of_fragments")]
	public int? NumberOfFragments { get; set; }
	[JsonInclude, JsonPropertyName("options")]
	public IDictionary<string, object>? Options { get; set; }

	/// <summary>
	/// <para>Sorts highlighted fragments by score when set to `score`.<br/>By default, fragments will be output in the order they appear in the field (order: `none`).<br/>Setting this option to `score` will output the most relevant fragments first.<br/>Each highlighter applies its own logic to compute relevancy scores.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("order")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterOrder? Order { get; set; }

	/// <summary>
	/// <para>Controls the number of matching phrases in a document that are considered.<br/>Prevents the `fvh` highlighter from analyzing too many phrases and consuming too much memory.<br/>When using `matched_fields`, `phrase_limit` phrases per matched field are considered. Raising the limit increases query time and consumes more memory.<br/>Only supported by the `fvh` highlighter.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("phrase_limit")]
	public int? PhraseLimit { get; set; }

	/// <summary>
	/// <para>Use in conjunction with `pre_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("post_tags")]
	public ICollection<string>? PostTags { get; set; }

	/// <summary>
	/// <para>Use in conjunction with `post_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pre_tags")]
	public ICollection<string>? PreTags { get; set; }

	/// <summary>
	/// <para>By default, only fields that contains a query match are highlighted.<br/>Set to `false` to highlight all fields.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("require_field_match")]
	public bool? RequireFieldMatch { get; set; }

	/// <summary>
	/// <para>Set to `styled` to use the built-in tag schema.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tags_schema")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterTagsSchema? TagsSchema { get; set; }
	[JsonInclude, JsonPropertyName("type")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterType? Type { get; set; }
}

public sealed partial class HighlightFieldDescriptor<TDocument> : SerializableDescriptor<HighlightFieldDescriptor<TDocument>>
{
	internal HighlightFieldDescriptor(Action<HighlightFieldDescriptor<TDocument>> configure) => configure.Invoke(this);

	public HighlightFieldDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Analysis.IAnalyzer? AnalyzerValue { get; set; }
	private string? BoundaryCharsValue { get; set; }
	private int? BoundaryMaxScanValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.BoundaryScanner? BoundaryScannerValue { get; set; }
	private string? BoundaryScannerLocaleValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterFragmenter? FragmenterValue { get; set; }
	private int? FragmentOffsetValue { get; set; }
	private int? FragmentSizeValue { get; set; }
	private bool? HighlightFilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? HighlightQueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> HighlightQueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> HighlightQueryDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? MatchedFieldsValue { get; set; }
	private int? MaxAnalyzedOffsetValue { get; set; }
	private int? MaxFragmentLengthValue { get; set; }
	private int? NoMatchSizeValue { get; set; }
	private int? NumberOfFragmentsValue { get; set; }
	private IDictionary<string, object>? OptionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterOrder? OrderValue { get; set; }
	private int? PhraseLimitValue { get; set; }
	private ICollection<string>? PostTagsValue { get; set; }
	private ICollection<string>? PreTagsValue { get; set; }
	private bool? RequireFieldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterTagsSchema? TagsSchemaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterType? TypeValue { get; set; }

	public HighlightFieldDescriptor<TDocument> Analyzer(Elastic.Clients.Elasticsearch.Serverless.Analysis.IAnalyzer? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>A string that contains each boundary character.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> BoundaryChars(string? boundaryChars)
	{
		BoundaryCharsValue = boundaryChars;
		return Self;
	}

	/// <summary>
	/// <para>How far to scan for boundary characters.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> BoundaryMaxScan(int? boundaryMaxScan)
	{
		BoundaryMaxScanValue = boundaryMaxScan;
		return Self;
	}

	/// <summary>
	/// <para>Specifies how to break the highlighted fragments: chars, sentence, or word.<br/>Only valid for the unified and fvh highlighters.<br/>Defaults to `sentence` for the `unified` highlighter. Defaults to `chars` for the `fvh` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> BoundaryScanner(Elastic.Clients.Elasticsearch.Serverless.Core.Search.BoundaryScanner? boundaryScanner)
	{
		BoundaryScannerValue = boundaryScanner;
		return Self;
	}

	/// <summary>
	/// <para>Controls which locale is used to search for sentence and word boundaries.<br/>This parameter takes a form of a language tag, for example: `"en-US"`, `"fr-FR"`, `"ja-JP"`.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> BoundaryScannerLocale(string? boundaryScannerLocale)
	{
		BoundaryScannerLocaleValue = boundaryScannerLocale;
		return Self;
	}

	/// <summary>
	/// <para>Specifies how text should be broken up in highlight snippets: `simple` or `span`.<br/>Only valid for the `plain` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> Fragmenter(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterFragmenter? fragmenter)
	{
		FragmenterValue = fragmenter;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> FragmentOffset(int? fragmentOffset)
	{
		FragmentOffsetValue = fragmentOffset;
		return Self;
	}

	/// <summary>
	/// <para>The size of the highlighted fragment in characters.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> FragmentSize(int? fragmentSize)
	{
		FragmentSizeValue = fragmentSize;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> HighlightFilter(bool? highlightFilter = true)
	{
		HighlightFilterValue = highlightFilter;
		return Self;
	}

	/// <summary>
	/// <para>Highlight matches for a query other than the search query.<br/>This is especially useful if you use a rescore query because those are not taken into account by highlighting by default.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> HighlightQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? highlightQuery)
	{
		HighlightQueryDescriptor = null;
		HighlightQueryDescriptorAction = null;
		HighlightQueryValue = highlightQuery;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> HighlightQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		HighlightQueryValue = null;
		HighlightQueryDescriptorAction = null;
		HighlightQueryDescriptor = descriptor;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> HighlightQuery(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		HighlightQueryValue = null;
		HighlightQueryDescriptor = null;
		HighlightQueryDescriptorAction = configure;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> MatchedFields(Elastic.Clients.Elasticsearch.Serverless.Fields? matchedFields)
	{
		MatchedFieldsValue = matchedFields;
		return Self;
	}

	/// <summary>
	/// <para>If set to a non-negative value, highlighting stops at this defined maximum limit.<br/>The rest of the text is not processed, thus not highlighted and no error is returned<br/>The `max_analyzed_offset` query setting does not override the `index.highlight.max_analyzed_offset` setting, which prevails when it’s set to lower value than the query setting.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> MaxAnalyzedOffset(int? maxAnalyzedOffset)
	{
		MaxAnalyzedOffsetValue = maxAnalyzedOffset;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> MaxFragmentLength(int? maxFragmentLength)
	{
		MaxFragmentLengthValue = maxFragmentLength;
		return Self;
	}

	/// <summary>
	/// <para>The amount of text you want to return from the beginning of the field if there are no matching fragments to highlight.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> NoMatchSize(int? noMatchSize)
	{
		NoMatchSizeValue = noMatchSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of fragments to return.<br/>If the number of fragments is set to `0`, no fragments are returned.<br/>Instead, the entire field contents are highlighted and returned.<br/>This can be handy when you need to highlight short texts such as a title or address, but fragmentation is not required.<br/>If `number_of_fragments` is `0`, `fragment_size` is ignored.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> NumberOfFragments(int? numberOfFragments)
	{
		NumberOfFragmentsValue = numberOfFragments;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> Options(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		OptionsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Sorts highlighted fragments by score when set to `score`.<br/>By default, fragments will be output in the order they appear in the field (order: `none`).<br/>Setting this option to `score` will output the most relevant fragments first.<br/>Each highlighter applies its own logic to compute relevancy scores.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>Controls the number of matching phrases in a document that are considered.<br/>Prevents the `fvh` highlighter from analyzing too many phrases and consuming too much memory.<br/>When using `matched_fields`, `phrase_limit` phrases per matched field are considered. Raising the limit increases query time and consumes more memory.<br/>Only supported by the `fvh` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> PhraseLimit(int? phraseLimit)
	{
		PhraseLimitValue = phraseLimit;
		return Self;
	}

	/// <summary>
	/// <para>Use in conjunction with `pre_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> PostTags(ICollection<string>? postTags)
	{
		PostTagsValue = postTags;
		return Self;
	}

	/// <summary>
	/// <para>Use in conjunction with `post_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> PreTags(ICollection<string>? preTags)
	{
		PreTagsValue = preTags;
		return Self;
	}

	/// <summary>
	/// <para>By default, only fields that contains a query match are highlighted.<br/>Set to `false` to highlight all fields.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> RequireFieldMatch(bool? requireFieldMatch = true)
	{
		RequireFieldMatchValue = requireFieldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Set to `styled` to use the built-in tag schema.</para>
	/// </summary>
	public HighlightFieldDescriptor<TDocument> TagsSchema(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterTagsSchema? tagsSchema)
	{
		TagsSchemaValue = tagsSchema;
		return Self;
	}

	public HighlightFieldDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterType? type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AnalyzerValue is not null)
		{
			writer.WritePropertyName("analyzer");
			JsonSerializer.Serialize(writer, AnalyzerValue, options);
		}

		if (!string.IsNullOrEmpty(BoundaryCharsValue))
		{
			writer.WritePropertyName("boundary_chars");
			writer.WriteStringValue(BoundaryCharsValue);
		}

		if (BoundaryMaxScanValue.HasValue)
		{
			writer.WritePropertyName("boundary_max_scan");
			writer.WriteNumberValue(BoundaryMaxScanValue.Value);
		}

		if (BoundaryScannerValue is not null)
		{
			writer.WritePropertyName("boundary_scanner");
			JsonSerializer.Serialize(writer, BoundaryScannerValue, options);
		}

		if (!string.IsNullOrEmpty(BoundaryScannerLocaleValue))
		{
			writer.WritePropertyName("boundary_scanner_locale");
			writer.WriteStringValue(BoundaryScannerLocaleValue);
		}

		if (FragmenterValue is not null)
		{
			writer.WritePropertyName("fragmenter");
			JsonSerializer.Serialize(writer, FragmenterValue, options);
		}

		if (FragmentOffsetValue.HasValue)
		{
			writer.WritePropertyName("fragment_offset");
			writer.WriteNumberValue(FragmentOffsetValue.Value);
		}

		if (FragmentSizeValue.HasValue)
		{
			writer.WritePropertyName("fragment_size");
			writer.WriteNumberValue(FragmentSizeValue.Value);
		}

		if (HighlightFilterValue.HasValue)
		{
			writer.WritePropertyName("highlight_filter");
			writer.WriteBooleanValue(HighlightFilterValue.Value);
		}

		if (HighlightQueryDescriptor is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, HighlightQueryDescriptor, options);
		}
		else if (HighlightQueryDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(HighlightQueryDescriptorAction), options);
		}
		else if (HighlightQueryValue is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, HighlightQueryValue, options);
		}

		if (MatchedFieldsValue is not null)
		{
			writer.WritePropertyName("matched_fields");
			JsonSerializer.Serialize(writer, MatchedFieldsValue, options);
		}

		if (MaxAnalyzedOffsetValue.HasValue)
		{
			writer.WritePropertyName("max_analyzed_offset");
			writer.WriteNumberValue(MaxAnalyzedOffsetValue.Value);
		}

		if (MaxFragmentLengthValue.HasValue)
		{
			writer.WritePropertyName("max_fragment_length");
			writer.WriteNumberValue(MaxFragmentLengthValue.Value);
		}

		if (NoMatchSizeValue.HasValue)
		{
			writer.WritePropertyName("no_match_size");
			writer.WriteNumberValue(NoMatchSizeValue.Value);
		}

		if (NumberOfFragmentsValue.HasValue)
		{
			writer.WritePropertyName("number_of_fragments");
			writer.WriteNumberValue(NumberOfFragmentsValue.Value);
		}

		if (OptionsValue is not null)
		{
			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, OptionsValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (PhraseLimitValue.HasValue)
		{
			writer.WritePropertyName("phrase_limit");
			writer.WriteNumberValue(PhraseLimitValue.Value);
		}

		if (PostTagsValue is not null)
		{
			writer.WritePropertyName("post_tags");
			JsonSerializer.Serialize(writer, PostTagsValue, options);
		}

		if (PreTagsValue is not null)
		{
			writer.WritePropertyName("pre_tags");
			JsonSerializer.Serialize(writer, PreTagsValue, options);
		}

		if (RequireFieldMatchValue.HasValue)
		{
			writer.WritePropertyName("require_field_match");
			writer.WriteBooleanValue(RequireFieldMatchValue.Value);
		}

		if (TagsSchemaValue is not null)
		{
			writer.WritePropertyName("tags_schema");
			JsonSerializer.Serialize(writer, TagsSchemaValue, options);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class HighlightFieldDescriptor : SerializableDescriptor<HighlightFieldDescriptor>
{
	internal HighlightFieldDescriptor(Action<HighlightFieldDescriptor> configure) => configure.Invoke(this);

	public HighlightFieldDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Analysis.IAnalyzer? AnalyzerValue { get; set; }
	private string? BoundaryCharsValue { get; set; }
	private int? BoundaryMaxScanValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.BoundaryScanner? BoundaryScannerValue { get; set; }
	private string? BoundaryScannerLocaleValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterFragmenter? FragmenterValue { get; set; }
	private int? FragmentOffsetValue { get; set; }
	private int? FragmentSizeValue { get; set; }
	private bool? HighlightFilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? HighlightQueryValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor HighlightQueryDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> HighlightQueryDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Fields? MatchedFieldsValue { get; set; }
	private int? MaxAnalyzedOffsetValue { get; set; }
	private int? MaxFragmentLengthValue { get; set; }
	private int? NoMatchSizeValue { get; set; }
	private int? NumberOfFragmentsValue { get; set; }
	private IDictionary<string, object>? OptionsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterOrder? OrderValue { get; set; }
	private int? PhraseLimitValue { get; set; }
	private ICollection<string>? PostTagsValue { get; set; }
	private ICollection<string>? PreTagsValue { get; set; }
	private bool? RequireFieldMatchValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterTagsSchema? TagsSchemaValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterType? TypeValue { get; set; }

	public HighlightFieldDescriptor Analyzer(Elastic.Clients.Elasticsearch.Serverless.Analysis.IAnalyzer? analyzer)
	{
		AnalyzerValue = analyzer;
		return Self;
	}

	/// <summary>
	/// <para>A string that contains each boundary character.</para>
	/// </summary>
	public HighlightFieldDescriptor BoundaryChars(string? boundaryChars)
	{
		BoundaryCharsValue = boundaryChars;
		return Self;
	}

	/// <summary>
	/// <para>How far to scan for boundary characters.</para>
	/// </summary>
	public HighlightFieldDescriptor BoundaryMaxScan(int? boundaryMaxScan)
	{
		BoundaryMaxScanValue = boundaryMaxScan;
		return Self;
	}

	/// <summary>
	/// <para>Specifies how to break the highlighted fragments: chars, sentence, or word.<br/>Only valid for the unified and fvh highlighters.<br/>Defaults to `sentence` for the `unified` highlighter. Defaults to `chars` for the `fvh` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor BoundaryScanner(Elastic.Clients.Elasticsearch.Serverless.Core.Search.BoundaryScanner? boundaryScanner)
	{
		BoundaryScannerValue = boundaryScanner;
		return Self;
	}

	/// <summary>
	/// <para>Controls which locale is used to search for sentence and word boundaries.<br/>This parameter takes a form of a language tag, for example: `"en-US"`, `"fr-FR"`, `"ja-JP"`.</para>
	/// </summary>
	public HighlightFieldDescriptor BoundaryScannerLocale(string? boundaryScannerLocale)
	{
		BoundaryScannerLocaleValue = boundaryScannerLocale;
		return Self;
	}

	/// <summary>
	/// <para>Specifies how text should be broken up in highlight snippets: `simple` or `span`.<br/>Only valid for the `plain` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor Fragmenter(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterFragmenter? fragmenter)
	{
		FragmenterValue = fragmenter;
		return Self;
	}

	public HighlightFieldDescriptor FragmentOffset(int? fragmentOffset)
	{
		FragmentOffsetValue = fragmentOffset;
		return Self;
	}

	/// <summary>
	/// <para>The size of the highlighted fragment in characters.</para>
	/// </summary>
	public HighlightFieldDescriptor FragmentSize(int? fragmentSize)
	{
		FragmentSizeValue = fragmentSize;
		return Self;
	}

	public HighlightFieldDescriptor HighlightFilter(bool? highlightFilter = true)
	{
		HighlightFilterValue = highlightFilter;
		return Self;
	}

	/// <summary>
	/// <para>Highlight matches for a query other than the search query.<br/>This is especially useful if you use a rescore query because those are not taken into account by highlighting by default.</para>
	/// </summary>
	public HighlightFieldDescriptor HighlightQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query? highlightQuery)
	{
		HighlightQueryDescriptor = null;
		HighlightQueryDescriptorAction = null;
		HighlightQueryValue = highlightQuery;
		return Self;
	}

	public HighlightFieldDescriptor HighlightQuery(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor descriptor)
	{
		HighlightQueryValue = null;
		HighlightQueryDescriptorAction = null;
		HighlightQueryDescriptor = descriptor;
		return Self;
	}

	public HighlightFieldDescriptor HighlightQuery(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> configure)
	{
		HighlightQueryValue = null;
		HighlightQueryDescriptor = null;
		HighlightQueryDescriptorAction = configure;
		return Self;
	}

	public HighlightFieldDescriptor MatchedFields(Elastic.Clients.Elasticsearch.Serverless.Fields? matchedFields)
	{
		MatchedFieldsValue = matchedFields;
		return Self;
	}

	/// <summary>
	/// <para>If set to a non-negative value, highlighting stops at this defined maximum limit.<br/>The rest of the text is not processed, thus not highlighted and no error is returned<br/>The `max_analyzed_offset` query setting does not override the `index.highlight.max_analyzed_offset` setting, which prevails when it’s set to lower value than the query setting.</para>
	/// </summary>
	public HighlightFieldDescriptor MaxAnalyzedOffset(int? maxAnalyzedOffset)
	{
		MaxAnalyzedOffsetValue = maxAnalyzedOffset;
		return Self;
	}

	public HighlightFieldDescriptor MaxFragmentLength(int? maxFragmentLength)
	{
		MaxFragmentLengthValue = maxFragmentLength;
		return Self;
	}

	/// <summary>
	/// <para>The amount of text you want to return from the beginning of the field if there are no matching fragments to highlight.</para>
	/// </summary>
	public HighlightFieldDescriptor NoMatchSize(int? noMatchSize)
	{
		NoMatchSizeValue = noMatchSize;
		return Self;
	}

	/// <summary>
	/// <para>The maximum number of fragments to return.<br/>If the number of fragments is set to `0`, no fragments are returned.<br/>Instead, the entire field contents are highlighted and returned.<br/>This can be handy when you need to highlight short texts such as a title or address, but fragmentation is not required.<br/>If `number_of_fragments` is `0`, `fragment_size` is ignored.</para>
	/// </summary>
	public HighlightFieldDescriptor NumberOfFragments(int? numberOfFragments)
	{
		NumberOfFragmentsValue = numberOfFragments;
		return Self;
	}

	public HighlightFieldDescriptor Options(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		OptionsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>Sorts highlighted fragments by score when set to `score`.<br/>By default, fragments will be output in the order they appear in the field (order: `none`).<br/>Setting this option to `score` will output the most relevant fragments first.<br/>Each highlighter applies its own logic to compute relevancy scores.</para>
	/// </summary>
	public HighlightFieldDescriptor Order(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	/// <summary>
	/// <para>Controls the number of matching phrases in a document that are considered.<br/>Prevents the `fvh` highlighter from analyzing too many phrases and consuming too much memory.<br/>When using `matched_fields`, `phrase_limit` phrases per matched field are considered. Raising the limit increases query time and consumes more memory.<br/>Only supported by the `fvh` highlighter.</para>
	/// </summary>
	public HighlightFieldDescriptor PhraseLimit(int? phraseLimit)
	{
		PhraseLimitValue = phraseLimit;
		return Self;
	}

	/// <summary>
	/// <para>Use in conjunction with `pre_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	public HighlightFieldDescriptor PostTags(ICollection<string>? postTags)
	{
		PostTagsValue = postTags;
		return Self;
	}

	/// <summary>
	/// <para>Use in conjunction with `post_tags` to define the HTML tags to use for the highlighted text.<br/>By default, highlighted text is wrapped in `<em>` and `</em>` tags.</para>
	/// </summary>
	public HighlightFieldDescriptor PreTags(ICollection<string>? preTags)
	{
		PreTagsValue = preTags;
		return Self;
	}

	/// <summary>
	/// <para>By default, only fields that contains a query match are highlighted.<br/>Set to `false` to highlight all fields.</para>
	/// </summary>
	public HighlightFieldDescriptor RequireFieldMatch(bool? requireFieldMatch = true)
	{
		RequireFieldMatchValue = requireFieldMatch;
		return Self;
	}

	/// <summary>
	/// <para>Set to `styled` to use the built-in tag schema.</para>
	/// </summary>
	public HighlightFieldDescriptor TagsSchema(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterTagsSchema? tagsSchema)
	{
		TagsSchemaValue = tagsSchema;
		return Self;
	}

	public HighlightFieldDescriptor Type(Elastic.Clients.Elasticsearch.Serverless.Core.Search.HighlighterType? type)
	{
		TypeValue = type;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (AnalyzerValue is not null)
		{
			writer.WritePropertyName("analyzer");
			JsonSerializer.Serialize(writer, AnalyzerValue, options);
		}

		if (!string.IsNullOrEmpty(BoundaryCharsValue))
		{
			writer.WritePropertyName("boundary_chars");
			writer.WriteStringValue(BoundaryCharsValue);
		}

		if (BoundaryMaxScanValue.HasValue)
		{
			writer.WritePropertyName("boundary_max_scan");
			writer.WriteNumberValue(BoundaryMaxScanValue.Value);
		}

		if (BoundaryScannerValue is not null)
		{
			writer.WritePropertyName("boundary_scanner");
			JsonSerializer.Serialize(writer, BoundaryScannerValue, options);
		}

		if (!string.IsNullOrEmpty(BoundaryScannerLocaleValue))
		{
			writer.WritePropertyName("boundary_scanner_locale");
			writer.WriteStringValue(BoundaryScannerLocaleValue);
		}

		if (FragmenterValue is not null)
		{
			writer.WritePropertyName("fragmenter");
			JsonSerializer.Serialize(writer, FragmenterValue, options);
		}

		if (FragmentOffsetValue.HasValue)
		{
			writer.WritePropertyName("fragment_offset");
			writer.WriteNumberValue(FragmentOffsetValue.Value);
		}

		if (FragmentSizeValue.HasValue)
		{
			writer.WritePropertyName("fragment_size");
			writer.WriteNumberValue(FragmentSizeValue.Value);
		}

		if (HighlightFilterValue.HasValue)
		{
			writer.WritePropertyName("highlight_filter");
			writer.WriteBooleanValue(HighlightFilterValue.Value);
		}

		if (HighlightQueryDescriptor is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, HighlightQueryDescriptor, options);
		}
		else if (HighlightQueryDescriptorAction is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(HighlightQueryDescriptorAction), options);
		}
		else if (HighlightQueryValue is not null)
		{
			writer.WritePropertyName("highlight_query");
			JsonSerializer.Serialize(writer, HighlightQueryValue, options);
		}

		if (MatchedFieldsValue is not null)
		{
			writer.WritePropertyName("matched_fields");
			JsonSerializer.Serialize(writer, MatchedFieldsValue, options);
		}

		if (MaxAnalyzedOffsetValue.HasValue)
		{
			writer.WritePropertyName("max_analyzed_offset");
			writer.WriteNumberValue(MaxAnalyzedOffsetValue.Value);
		}

		if (MaxFragmentLengthValue.HasValue)
		{
			writer.WritePropertyName("max_fragment_length");
			writer.WriteNumberValue(MaxFragmentLengthValue.Value);
		}

		if (NoMatchSizeValue.HasValue)
		{
			writer.WritePropertyName("no_match_size");
			writer.WriteNumberValue(NoMatchSizeValue.Value);
		}

		if (NumberOfFragmentsValue.HasValue)
		{
			writer.WritePropertyName("number_of_fragments");
			writer.WriteNumberValue(NumberOfFragmentsValue.Value);
		}

		if (OptionsValue is not null)
		{
			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, OptionsValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (PhraseLimitValue.HasValue)
		{
			writer.WritePropertyName("phrase_limit");
			writer.WriteNumberValue(PhraseLimitValue.Value);
		}

		if (PostTagsValue is not null)
		{
			writer.WritePropertyName("post_tags");
			JsonSerializer.Serialize(writer, PostTagsValue, options);
		}

		if (PreTagsValue is not null)
		{
			writer.WritePropertyName("pre_tags");
			JsonSerializer.Serialize(writer, PreTagsValue, options);
		}

		if (RequireFieldMatchValue.HasValue)
		{
			writer.WritePropertyName("require_field_match");
			writer.WriteBooleanValue(RequireFieldMatchValue.Value);
		}

		if (TagsSchemaValue is not null)
		{
			writer.WritePropertyName("tags_schema");
			JsonSerializer.Serialize(writer, TagsSchemaValue, options);
		}

		if (TypeValue is not null)
		{
			writer.WritePropertyName("type");
			JsonSerializer.Serialize(writer, TypeValue, options);
		}

		writer.WriteEndObject();
	}
}