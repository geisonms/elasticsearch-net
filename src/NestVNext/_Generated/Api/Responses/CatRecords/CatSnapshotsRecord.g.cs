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
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatSnapshotsRecord
	{
		[JsonInclude, JsonPropertyName("dur")]
		private Time? _dur = default;
		[JsonInclude, JsonPropertyName("duration")]
		private Time? _duration = default;
		[JsonInclude, JsonPropertyName("end_epoch")]
		private EpochMillis? _end_epoch = default;
		[JsonInclude, JsonPropertyName("end_time")]
		private DateString? _end_time = default;
		[JsonInclude, JsonPropertyName("endEpoch")]
		private EpochMillis? _endEpoch = default;
		[JsonInclude, JsonPropertyName("endTime")]
		private DateString? _endTime = default;
		[JsonInclude, JsonPropertyName("ete")]
		private EpochMillis? _ete = default;
		[JsonInclude, JsonPropertyName("eti")]
		private DateString? _eti = default;
		[JsonInclude, JsonPropertyName("failed_shards")]
		private string? _failed_shards = default;
		[JsonInclude, JsonPropertyName("fs")]
		private string? _fs = default;
		[JsonInclude, JsonPropertyName("i")]
		private string? _i = default;
		[JsonInclude, JsonPropertyName("id")]
		private string? _id = default;
		[JsonInclude, JsonPropertyName("indices")]
		private string? _indices = default;
		[JsonInclude, JsonPropertyName("r")]
		private string? _r = default;
		[JsonInclude, JsonPropertyName("re")]
		private string? _re = default;
		[JsonInclude, JsonPropertyName("reason")]
		private string? _reason = default;
		[JsonInclude, JsonPropertyName("repo")]
		private string? _repo = default;
		[JsonInclude, JsonPropertyName("repository")]
		private string? _repository = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("snapshot")]
		private string? _snapshot = default;
		[JsonInclude, JsonPropertyName("ss")]
		private string? _ss = default;
		[JsonInclude, JsonPropertyName("start_epoch")]
		private EpochMillis? _start_epoch = default;
		[JsonInclude, JsonPropertyName("start_time")]
		private DateString? _start_time = default;
		[JsonInclude, JsonPropertyName("startEpoch")]
		private EpochMillis? _startEpoch = default;
		[JsonInclude, JsonPropertyName("startTime")]
		private DateString? _startTime = default;
		[JsonInclude, JsonPropertyName("status")]
		private string? _status = default;
		[JsonInclude, JsonPropertyName("ste")]
		private EpochMillis? _ste = default;
		[JsonInclude, JsonPropertyName("sti")]
		private DateString? _sti = default;
		[JsonInclude, JsonPropertyName("successful_shards")]
		private string? _successful_shards = default;
		[JsonInclude, JsonPropertyName("total_shards")]
		private string? _total_shards = default;
		[JsonInclude, JsonPropertyName("ts")]
		private string? _ts = default;
		public Time? Duration => _dur ?? _duration;
		public EpochMillis? EndEpoch => _end_epoch ?? _ete ?? _endEpoch;
		public DateString? EndTime => _end_time ?? _eti ?? _endTime;
		public string? FailedShards => _fs ?? _failed_shards;
		public string? Id => _snapshot ?? _id;
		public string? Indices => _i ?? _indices;
		public string? Reason => _r ?? _reason;
		public string? Repository => _repository ?? _re ?? _repo;
		public EpochMillis? StartEpoch => _start_epoch ?? _ste ?? _startEpoch;
		public DateString? StartTime => _start_time ?? _sti ?? _startTime;
		public string? Status => _s ?? _status;
		public string? SuccessfulShards => _ss ?? _successful_shards;
		public string? TotalShards => _ts ?? _total_shards;
	}
}