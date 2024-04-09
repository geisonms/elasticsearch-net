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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class KnnQuery
{
	/// <summary>
	/// <para>Boost value to apply to kNN scores</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("boost")]
	public float? Boost { get; set; }

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Serverless.Field Field { get; set; }

	/// <summary>
	/// <para>Filters for the kNN search query</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inner_hits")]
	public Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHits { get; set; }

	/// <summary>
	/// <para>The final number of nearest neighbors to return as top hits</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("k")]
	public long k { get; set; }

	/// <summary>
	/// <para>The number of nearest neighbor candidates to consider per shard</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("num_candidates")]
	public long NumCandidates { get; set; }

	/// <summary>
	/// <para>The query vector</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query_vector")]
	public ICollection<float>? QueryVector { get; set; }

	/// <summary>
	/// <para>The query vector builder. You must provide a query_vector_builder or query_vector, but not both.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query_vector_builder")]
	public Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilder? QueryVectorBuilder { get; set; }

	/// <summary>
	/// <para>The minimum similarity for a vector to be considered a match</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("similarity")]
	public float? Similarity { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query(KnnQuery knnQuery) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query.Knn(knnQuery);
}

public sealed partial class KnnQueryDescriptor<TDocument> : SerializableDescriptor<KnnQueryDescriptor<TDocument>>
{
	internal KnnQueryDescriptor(Action<KnnQueryDescriptor<TDocument>> configure) => configure.Invoke(this);

	public KnnQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument> InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>> InnerHitsDescriptorAction { get; set; }
	private long kValue { get; set; }
	private long NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>Boost value to apply to kNN scores</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Filters for the kNN search query</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument> descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> InnerHits(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The final number of nearest neighbors to return as top hits</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> k(long k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>The number of nearest neighbor candidates to consider per shard</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> NumCandidates(long numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>The query vector</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>The query vector builder. You must provide a query_vector_builder or query_vector, but not both.</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> QueryVectorBuilder(Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor<TDocument> QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The minimum similarity for a vector to be considered a match</para>
	/// </summary>
	public KnnQueryDescriptor<TDocument> Similarity(float? similarity)
	{
		SimilarityValue = similarity;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor<TDocument>(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class KnnQueryDescriptor : SerializableDescriptor<KnnQueryDescriptor>
{
	internal KnnQueryDescriptor(Action<KnnQueryDescriptor> configure) => configure.Invoke(this);

	public KnnQueryDescriptor() : base()
	{
	}

	private float? BoostValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field FieldValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? InnerHitsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor InnerHitsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor> InnerHitsDescriptorAction { get; set; }
	private long kValue { get; set; }
	private long NumCandidatesValue { get; set; }
	private ICollection<float>? QueryVectorValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilder? QueryVectorBuilderValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor QueryVectorBuilderDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor> QueryVectorBuilderDescriptorAction { get; set; }
	private float? SimilarityValue { get; set; }

	/// <summary>
	/// <para>Boost value to apply to kNN scores</para>
	/// </summary>
	public KnnQueryDescriptor Boost(float? boost)
	{
		BoostValue = boost;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor Field(Elastic.Clients.Elasticsearch.Serverless.Field field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The name of the vector field to search against</para>
	/// </summary>
	public KnnQueryDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Filters for the kNN search query</para>
	/// </summary>
	public KnnQueryDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public KnnQueryDescriptor Filter(Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor Filter(Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public KnnQueryDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>If defined, each search hit will contain inner hits.</para>
	/// </summary>
	public KnnQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHits? innerHits)
	{
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = null;
		InnerHitsValue = innerHits;
		return Self;
	}

	public KnnQueryDescriptor InnerHits(Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor descriptor)
	{
		InnerHitsValue = null;
		InnerHitsDescriptorAction = null;
		InnerHitsDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor InnerHits(Action<Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor> configure)
	{
		InnerHitsValue = null;
		InnerHitsDescriptor = null;
		InnerHitsDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The final number of nearest neighbors to return as top hits</para>
	/// </summary>
	public KnnQueryDescriptor k(long k)
	{
		kValue = k;
		return Self;
	}

	/// <summary>
	/// <para>The number of nearest neighbor candidates to consider per shard</para>
	/// </summary>
	public KnnQueryDescriptor NumCandidates(long numCandidates)
	{
		NumCandidatesValue = numCandidates;
		return Self;
	}

	/// <summary>
	/// <para>The query vector</para>
	/// </summary>
	public KnnQueryDescriptor QueryVector(ICollection<float>? queryVector)
	{
		QueryVectorValue = queryVector;
		return Self;
	}

	/// <summary>
	/// <para>The query vector builder. You must provide a query_vector_builder or query_vector, but not both.</para>
	/// </summary>
	public KnnQueryDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilder? queryVectorBuilder)
	{
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderValue = queryVectorBuilder;
		return Self;
	}

	public KnnQueryDescriptor QueryVectorBuilder(Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor descriptor)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptorAction = null;
		QueryVectorBuilderDescriptor = descriptor;
		return Self;
	}

	public KnnQueryDescriptor QueryVectorBuilder(Action<Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor> configure)
	{
		QueryVectorBuilderValue = null;
		QueryVectorBuilderDescriptor = null;
		QueryVectorBuilderDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>The minimum similarity for a vector to be considered a match</para>
	/// </summary>
	public KnnQueryDescriptor Similarity(float? similarity)
	{
		SimilarityValue = similarity;
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

		writer.WritePropertyName("field");
		JsonSerializer.Serialize(writer, FieldValue, options);
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryDsl.QueryDescriptor(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.Serverless.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (InnerHitsDescriptor is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsDescriptor, options);
		}
		else if (InnerHitsDescriptorAction is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Core.Search.InnerHitsDescriptor(InnerHitsDescriptorAction), options);
		}
		else if (InnerHitsValue is not null)
		{
			writer.WritePropertyName("inner_hits");
			JsonSerializer.Serialize(writer, InnerHitsValue, options);
		}

		writer.WritePropertyName("k");
		writer.WriteNumberValue(kValue);
		writer.WritePropertyName("num_candidates");
		writer.WriteNumberValue(NumCandidatesValue);
		if (QueryVectorValue is not null)
		{
			writer.WritePropertyName("query_vector");
			JsonSerializer.Serialize(writer, QueryVectorValue, options);
		}

		if (QueryVectorBuilderDescriptor is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderDescriptor, options);
		}
		else if (QueryVectorBuilderDescriptorAction is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.QueryVectorBuilderDescriptor(QueryVectorBuilderDescriptorAction), options);
		}
		else if (QueryVectorBuilderValue is not null)
		{
			writer.WritePropertyName("query_vector_builder");
			JsonSerializer.Serialize(writer, QueryVectorBuilderValue, options);
		}

		if (SimilarityValue.HasValue)
		{
			writer.WritePropertyName("similarity");
			writer.WriteNumberValue(SimilarityValue.Value);
		}

		writer.WriteEndObject();
	}
}