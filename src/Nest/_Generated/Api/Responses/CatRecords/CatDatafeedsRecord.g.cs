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
// Run the following in the root of the repository:
//
// ------------------------------------------------

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatDatafeedsRecord
	{
		[JsonInclude, JsonPropertyName("ae")]
		private string? _ae = default;
		[JsonInclude, JsonPropertyName("assignment_explanation")]
		private string? _assignment_explanation = default;
		[JsonInclude, JsonPropertyName("bc")]
		private string? _bc = default;
		[JsonInclude, JsonPropertyName("buckets.count")]
		private string? _buckets_count = default;
		[JsonInclude, JsonPropertyName("bucketsCount")]
		private string? _bucketsCount = default;
		[JsonInclude, JsonPropertyName("na")]
		private string? _na = default;
		[JsonInclude, JsonPropertyName("ne")]
		private string? _ne = default;
		[JsonInclude, JsonPropertyName("ni")]
		private string? _ni = default;
		[JsonInclude, JsonPropertyName("nn")]
		private string? _nn = default;
		[JsonInclude, JsonPropertyName("node.address")]
		private string? _node_address = default;
		[JsonInclude, JsonPropertyName("node.ephemeral_id")]
		private string? _node_ephemeral_id = default;
		[JsonInclude, JsonPropertyName("node.id")]
		private string? _node_id = default;
		[JsonInclude, JsonPropertyName("node.name")]
		private string? _node_name = default;
		[JsonInclude, JsonPropertyName("nodeAddress")]
		private string? _nodeAddress = default;
		[JsonInclude, JsonPropertyName("nodeEphemeralId")]
		private string? _nodeEphemeralId = default;
		[JsonInclude, JsonPropertyName("nodeId")]
		private string? _nodeId = default;
		[JsonInclude, JsonPropertyName("nodeName")]
		private string? _nodeName = default;
		[JsonInclude, JsonPropertyName("s")]
		private DatafeedState? _s = default;
		[JsonInclude, JsonPropertyName("sba")]
		private string? _sba = default;
		[JsonInclude, JsonPropertyName("sc")]
		private string? _sc = default;
		[JsonInclude, JsonPropertyName("seah")]
		private string? _seah = default;
		[JsonInclude, JsonPropertyName("search.bucket_avg")]
		private string? _search_bucket_avg = default;
		[JsonInclude, JsonPropertyName("search.count")]
		private string? _search_count = default;
		[JsonInclude, JsonPropertyName("search.exp_avg_hour")]
		private string? _search_exp_avg_hour = default;
		[JsonInclude, JsonPropertyName("search.time")]
		private string? _search_time = default;
		[JsonInclude, JsonPropertyName("searchBucketAvg")]
		private string? _searchBucketAvg = default;
		[JsonInclude, JsonPropertyName("searchCount")]
		private string? _searchCount = default;
		[JsonInclude, JsonPropertyName("searchExpAvgHour")]
		private string? _searchExpAvgHour = default;
		[JsonInclude, JsonPropertyName("searchTime")]
		private string? _searchTime = default;
		[JsonInclude, JsonPropertyName("st")]
		private string? _st = default;
		[JsonInclude, JsonPropertyName("state")]
		private DatafeedState? _state = default;
		public string? AssignmentExplanation => _ae ?? _assignment_explanation;
		public string? BucketsCount => _buckets_count ?? _bc ?? _bucketsCount;
		[JsonPropertyName("id")]
		public string? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? NodeAddress => _node_address ?? _na ?? _nodeAddress;
		public string? NodeEphemeralId => _node_ephemeral_id ?? _ne ?? _nodeEphemeralId;
		public string? NodeId => _node_id ?? _ni ?? _nodeId;
		public string? NodeName => _node_name ?? _nn ?? _nodeName;
		public string? SearchBucketAvg => _search_bucket_avg ?? _sba ?? _searchBucketAvg;
		public string? SearchCount => _search_count ?? _sc ?? _searchCount;
		public string? SearchExpAvgHour => _search_exp_avg_hour ?? _seah ?? _searchExpAvgHour;
		public string? SearchTime => _search_time ?? _st ?? _searchTime;
		public DatafeedState? State => _s ?? _state;
	}
}