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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class Queries
	{
		[JsonInclude]
		[JsonPropertyName("cache")]
		public Elastic.Clients.Elasticsearch.IndexManagement.CacheQueries? Cache { get; set; }
	}

	public sealed partial class QueriesDescriptor : DescriptorBase<QueriesDescriptor>
	{
		public QueriesDescriptor()
		{
		}

		internal QueriesDescriptor(Action<QueriesDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.IndexManagement.CacheQueries? CacheValue { get; private set; }

		internal CacheQueriesDescriptor CacheDescriptor { get; private set; }

		internal Action<CacheQueriesDescriptor> CacheDescriptorAction { get; private set; }

		public QueriesDescriptor Cache(Elastic.Clients.Elasticsearch.IndexManagement.CacheQueries? cache)
		{
			CacheDescriptor = null;
			CacheDescriptorAction = null;
			return Assign(cache, (a, v) => a.CacheValue = v);
		}

		public QueriesDescriptor Cache(IndexManagement.CacheQueriesDescriptor descriptor)
		{
			CacheValue = null;
			CacheDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.CacheDescriptor = v);
		}

		public QueriesDescriptor Cache(Action<IndexManagement.CacheQueriesDescriptor> configure)
		{
			CacheValue = null;
			CacheDescriptorAction = null;
			return Assign(configure, (a, v) => a.CacheDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (CacheDescriptor is not null)
			{
				writer.WritePropertyName("cache");
				JsonSerializer.Serialize(writer, CacheDescriptor, options);
			}
			else if (CacheDescriptorAction is not null)
			{
				writer.WritePropertyName("cache");
				JsonSerializer.Serialize(writer, new IndexManagement.CacheQueriesDescriptor(CacheDescriptorAction), options);
			}
			else if (CacheValue is not null)
			{
				writer.WritePropertyName("cache");
				JsonSerializer.Serialize(writer, CacheValue, options);
			}

			writer.WriteEndObject();
		}
	}
}