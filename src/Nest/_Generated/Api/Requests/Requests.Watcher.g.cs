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

using Elastic.Transport;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Watcher
{
	[ConvertAs(typeof(AckWatchRequest))]
	public partial interface IAckWatchRequest : IRequest<AckWatchRequestParameters>
	{
	}

	public partial class AckWatchRequest : PlainRequestBase<AckWatchRequestParameters>, IAckWatchRequest
	{
		protected IAckWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherAckWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{watch_id}/_ack</summary>
        public AckWatchRequest(Nest.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}

		///<summary>/_watcher/watch/{watch_id}/_ack/{action_id}</summary>
        public AckWatchRequest(Nest.Name watch_id, Nest.Names? action_id) : base(r => r.Required("watch_id", watch_id).Optional("action_id", action_id))
		{
		}
	}

	[ConvertAs(typeof(ActivateWatchRequest))]
	public partial interface IActivateWatchRequest : IRequest<ActivateWatchRequestParameters>
	{
	}

	public partial class ActivateWatchRequest : PlainRequestBase<ActivateWatchRequestParameters>, IActivateWatchRequest
	{
		protected IActivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherActivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{watch_id}/_activate</summary>
        public ActivateWatchRequest(Nest.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}
	}

	[ConvertAs(typeof(DeactivateWatchRequest))]
	public partial interface IDeactivateWatchRequest : IRequest<DeactivateWatchRequestParameters>
	{
	}

	public partial class DeactivateWatchRequest : PlainRequestBase<DeactivateWatchRequestParameters>, IDeactivateWatchRequest
	{
		protected IDeactivateWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeactivateWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{watch_id}/_deactivate</summary>
        public DeactivateWatchRequest(Nest.Name watch_id) : base(r => r.Required("watch_id", watch_id))
		{
		}
	}

	[ConvertAs(typeof(DeleteWatchRequest))]
	public partial interface IDeleteWatchRequest : IRequest<DeleteWatchRequestParameters>
	{
	}

	public partial class DeleteWatchRequest : PlainRequestBase<DeleteWatchRequestParameters>, IDeleteWatchRequest
	{
		protected IDeleteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherDeleteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{id}</summary>
        public DeleteWatchRequest(Nest.Name id) : base(r => r.Required("id", id))
		{
		}
	}

	[ConvertAs(typeof(ExecuteWatchRequest))]
	public partial interface IExecuteWatchRequest : IRequest<ExecuteWatchRequestParameters>
	{
		Dictionary<string, Nest.Watcher.ActionExecutionMode>? ActionModes { get; set; }

		Dictionary<string, object>? AlternativeInput { get; set; }

		bool? IgnoreCondition { get; set; }

		bool? RecordExecution { get; set; }

		Nest.Watcher.SimulatedActions? SimulatedActions { get; set; }

		Nest.Watcher.ScheduleTriggerEvent? TriggerData { get; set; }

		Nest.Watcher.Watch? Watch { get; set; }
	}

	public partial class ExecuteWatchRequest : PlainRequestBase<ExecuteWatchRequestParameters>, IExecuteWatchRequest
	{
		protected IExecuteWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherExecuteWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => ActionModes is null && AlternativeInput is null && IgnoreCondition is null && RecordExecution is null && SimulatedActions is null && TriggerData is null && Watch is null;

		///<summary>/_watcher/watch/{id}/_execute</summary>
        public ExecuteWatchRequest(Nest.Id? id) : base(r => r.Optional("id", id))
		{
		}

		///<summary>/_watcher/watch/_execute</summary>
        public ExecuteWatchRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? Debug { get => Q<bool?>("debug"); set => Q("debug", value); }

		[JsonPropertyName("action_modes")]
		public Dictionary<string, Nest.Watcher.ActionExecutionMode>? ActionModes { get; set; }

		[JsonPropertyName("alternative_input")]
		public Dictionary<string, object>? AlternativeInput { get; set; }

		[JsonPropertyName("ignore_condition")]
		public bool? IgnoreCondition { get; set; }

		[JsonPropertyName("record_execution")]
		public bool? RecordExecution { get; set; }

		[JsonPropertyName("simulated_actions")]
		public Nest.Watcher.SimulatedActions? SimulatedActions { get; set; }

		[JsonPropertyName("trigger_data")]
		public Nest.Watcher.ScheduleTriggerEvent? TriggerData { get; set; }

		[JsonPropertyName("watch")]
		public Nest.Watcher.Watch? Watch { get; set; }
	}

	[ConvertAs(typeof(GetWatchRequest))]
	public partial interface IGetWatchRequest : IRequest<GetWatchRequestParameters>
	{
	}

	public partial class GetWatchRequest : PlainRequestBase<GetWatchRequestParameters>, IGetWatchRequest
	{
		protected IGetWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherGetWatch;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{id}</summary>
        public GetWatchRequest(Nest.Name id) : base(r => r.Required("id", id))
		{
		}
	}

	[ConvertAs(typeof(PutWatchRequest))]
	public partial interface IPutWatchRequest : IRequest<PutWatchRequestParameters>
	{
		Dictionary<string, Nest.Watcher.Action>? Actions { get; set; }

		Nest.Watcher.ConditionContainer? Condition { get; set; }

		Nest.Watcher.InputContainer? Input { get; set; }

		Nest.Metadata? Metadata { get; set; }

		string? ThrottlePeriod { get; set; }

		Nest.TransformContainer? Transform { get; set; }

		Nest.Watcher.TriggerContainer? Trigger { get; set; }
	}

	public partial class PutWatchRequest : PlainRequestBase<PutWatchRequestParameters>, IPutWatchRequest
	{
		protected IPutWatchRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherPutWatch;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_watcher/watch/{id}</summary>
        public PutWatchRequest(Nest.Id id) : base(r => r.Required("id", id))
		{
		}

		[JsonIgnore]
		public bool? Active { get => Q<bool?>("active"); set => Q("active", value); }

		[JsonIgnore]
		public long? IfPrimaryTerm { get => Q<long?>("if_primary_term"); set => Q("if_primary_term", value); }

		[JsonIgnore]
		public long? IfSequenceNumber { get => Q<long?>("if_sequence_number"); set => Q("if_sequence_number", value); }

		[JsonIgnore]
		public Nest.VersionNumber? Version { get => Q<Nest.VersionNumber?>("version"); set => Q("version", value); }

		[JsonPropertyName("actions")]
		public Dictionary<string, Nest.Watcher.Action>? Actions { get; set; }

		[JsonPropertyName("condition")]
		public Nest.Watcher.ConditionContainer? Condition { get; set; }

		[JsonPropertyName("input")]
		public Nest.Watcher.InputContainer? Input { get; set; }

		[JsonPropertyName("metadata")]
		public Nest.Metadata? Metadata { get; set; }

		[JsonPropertyName("throttle_period")]
		public string? ThrottlePeriod { get; set; }

		[JsonPropertyName("transform")]
		public Nest.TransformContainer? Transform { get; set; }

		[JsonPropertyName("trigger")]
		public Nest.Watcher.TriggerContainer? Trigger { get; set; }
	}

	[ConvertAs(typeof(QueryWatchesRequest))]
	public partial interface IQueryWatchesRequest : IRequest<QueryWatchesRequestParameters>
	{
		int? From { get; set; }

		int? Size { get; set; }

		Nest.QueryDsl.QueryContainer? Query { get; set; }

		Nest.Global.Search.Sort? Sort { get; set; }

		Nest.Global.Search.SortResults? SearchAfter { get; set; }
	}

	public partial class QueryWatchesRequest : PlainRequestBase<QueryWatchesRequestParameters>, IQueryWatchesRequest
	{
		protected IQueryWatchesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherQueryWatches;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => From is null && Size is null && Query is null && SearchAfter is null;

		///<summary>/_watcher/_query/watches</summary>
        public QueryWatchesRequest() : base()
		{
		}

		[JsonPropertyName("from")]
		public int? From { get; set; }

		[JsonPropertyName("size")]
		public int? Size { get; set; }

		[JsonPropertyName("query")]
		public Nest.QueryDsl.QueryContainer? Query { get; set; }

		[JsonPropertyName("sort")]
		public Nest.Global.Search.Sort? Sort { get; set; }

		[JsonPropertyName("search_after")]
		public Nest.Global.Search.SortResults? SearchAfter { get; set; }
	}

	[ConvertAs(typeof(StartRequest))]
	public partial interface IStartRequest : IRequest<StartRequestParameters>
	{
	}

	public partial class StartRequest : PlainRequestBase<StartRequestParameters>, IStartRequest
	{
		protected IStartRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_watcher/_start</summary>
        public StartRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(StatsRequest))]
	public partial interface IStatsRequest : IRequest<StatsRequestParameters>
	{
	}

	public partial class StatsRequest : PlainRequestBase<StatsRequestParameters>, IStatsRequest
	{
		protected IStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_watcher/stats</summary>
        public StatsRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? EmitStacktraces { get => Q<bool?>("emit_stacktraces"); set => Q("emit_stacktraces", value); }
	}

	[ConvertAs(typeof(StopRequest))]
	public partial interface IStopRequest : IRequest<StopRequestParameters>
	{
	}

	public partial class StopRequest : PlainRequestBase<StopRequestParameters>, IStopRequest
	{
		protected IStopRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.WatcherStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_watcher/_stop</summary>
        public StopRequest() : base()
		{
		}
	}
}