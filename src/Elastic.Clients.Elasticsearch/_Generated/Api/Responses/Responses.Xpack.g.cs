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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public partial class InfoResponse : ResponseBase
	{
		[JsonPropertyName("build")]
		public Elastic.Clients.Elasticsearch.Xpack.Info.BuildInformation Build
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("features")]
		public Elastic.Clients.Elasticsearch.Xpack.Info.Features Features
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("license")]
		public Elastic.Clients.Elasticsearch.Xpack.Info.MinimalLicenseInformation License
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("tagline")]
		public string Tagline
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	public partial class UsageResponse : ResponseBase
	{
		[JsonPropertyName("aggregate_metric")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base AggregateMetric
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("analytics")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Analytics Analytics
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ccr")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Ccr Ccr
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_frame")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base? DataFrame
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_science")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base? DataScience
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_streams")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataStreams? DataStreams
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("data_tiers")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.DataTiers DataTiers
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("enrich")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base? Enrich
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("eql")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Eql Eql
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("flattened")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Flattened? Flattened
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("frozen_indices")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.FrozenIndices FrozenIndices
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("graph")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base Graph
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ilm")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Ilm Ilm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("logstash")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base Logstash
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("ml")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.MachineLearning Ml
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("monitoring")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Monitoring Monitoring
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("rollup")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base Rollup
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("runtime_fields")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.RuntimeFieldTypes? RuntimeFields
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("searchable_snapshots")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.SearchableSnapshots SearchableSnapshots
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("security")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Security Security
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("slm")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Slm Slm
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("spatial")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base Spatial
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("sql")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Sql Sql
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("transform")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base Transform
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("vectors")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Vector Vectors
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("voting_only")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Base VotingOnly
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("watcher")]
		public Elastic.Clients.Elasticsearch.Xpack.Usage.Watcher Watcher
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}
}