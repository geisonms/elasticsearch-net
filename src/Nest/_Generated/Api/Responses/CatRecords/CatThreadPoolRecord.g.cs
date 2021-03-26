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
	public class CatThreadPoolRecord
	{
		[JsonInclude, JsonPropertyName("a")]
		private string? _a = default;
		[JsonInclude, JsonPropertyName("active")]
		private string? _active = default;
		[JsonInclude, JsonPropertyName("c")]
		private string? _c = default;
		[JsonInclude, JsonPropertyName("completed")]
		private string? _completed = default;
		[JsonInclude, JsonPropertyName("core")]
		private string? _core = default;
		[JsonInclude, JsonPropertyName("cr")]
		private string? _cr = default;
		[JsonInclude, JsonPropertyName("eid")]
		private string? _eid = default;
		[JsonInclude, JsonPropertyName("ephemeral_node_id")]
		private string? _ephemeral_node_id = default;
		[JsonInclude, JsonPropertyName("h")]
		private string? _h = default;
		[JsonInclude, JsonPropertyName("host")]
		private string? _host = default;
		[JsonInclude, JsonPropertyName("i")]
		private string? _i = default;
		[JsonInclude, JsonPropertyName("id")]
		private NodeId? _id = default;
		[JsonInclude, JsonPropertyName("ip")]
		private string? _ip = default;
		[JsonInclude, JsonPropertyName("ka")]
		private string? _ka = default;
		[JsonInclude, JsonPropertyName("keep_alive")]
		private string? _keep_alive = default;
		[JsonInclude, JsonPropertyName("l")]
		private string? _l = default;
		[JsonInclude, JsonPropertyName("largest")]
		private string? _largest = default;
		[JsonInclude, JsonPropertyName("max")]
		private string? _max = default;
		[JsonInclude, JsonPropertyName("mx")]
		private string? _mx = default;
		[JsonInclude, JsonPropertyName("n")]
		private string? _n = default;
		[JsonInclude, JsonPropertyName("name")]
		private string? _name = default;
		[JsonInclude, JsonPropertyName("nn")]
		private string? _nn = default;
		[JsonInclude, JsonPropertyName("node_id")]
		private NodeId? _node_id = default;
		[JsonInclude, JsonPropertyName("node_name")]
		private string? _node_name = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("pid")]
		private string? _pid = default;
		[JsonInclude, JsonPropertyName("po")]
		private string? _po = default;
		[JsonInclude, JsonPropertyName("pool_size")]
		private string? _pool_size = default;
		[JsonInclude, JsonPropertyName("port")]
		private string? _port = default;
		[JsonInclude, JsonPropertyName("psz")]
		private string? _psz = default;
		[JsonInclude, JsonPropertyName("q")]
		private string? _q = default;
		[JsonInclude, JsonPropertyName("qs")]
		private string? _qs = default;
		[JsonInclude, JsonPropertyName("queue")]
		private string? _queue = default;
		[JsonInclude, JsonPropertyName("queue_size")]
		private string? _queue_size = default;
		[JsonInclude, JsonPropertyName("r")]
		private string? _r = default;
		[JsonInclude, JsonPropertyName("rejected")]
		private string? _rejected = default;
		[JsonInclude, JsonPropertyName("size")]
		private string? _size = default;
		[JsonInclude, JsonPropertyName("sz")]
		private string? _sz = default;
		[JsonInclude, JsonPropertyName("t")]
		private string? _t = default;
		[JsonInclude, JsonPropertyName("type")]
		private string? _type = default;
		public string? Active => _a ?? _active;
		public string? Completed => _c ?? _completed;
		public string? Core => _cr ?? _core;
		public string? EphemeralNodeId => _eid ?? _ephemeral_node_id;
		public string? Host => _h ?? _host;
		public string? Ip => _i ?? _ip;
		public string? KeepAlive => _ka ?? _keep_alive;
		public string? Largest => _l ?? _largest;
		public string? Max => _mx ?? _max;
		public string? Name => _n ?? _name;
		public NodeId? NodeId => _id ?? _node_id;
		public string? NodeName => _nn ?? _node_name;
		public string? Pid => _p ?? _pid;
		public string? PoolSize => _psz ?? _pool_size;
		public string? Port => _po ?? _port;
		public string? Queue => _q ?? _queue;
		public string? QueueSize => _qs ?? _queue_size;
		public string? Rejected => _r ?? _rejected;
		public string? Size => _sz ?? _size;
		public string? Type => _t ?? _type;
	}
}