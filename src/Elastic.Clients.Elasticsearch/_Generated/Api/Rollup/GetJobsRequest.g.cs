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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Rollup;

public sealed partial class GetJobsRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Retrieves the configuration, stats, and status of rollup jobs.</para>
/// </summary>
public sealed partial class GetJobsRequest : PlainRequest<GetJobsRequestParameters>
{
	public GetJobsRequest()
	{
	}

	public GetJobsRequest(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupGetJobs;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.get_jobs";
}

/// <summary>
/// <para>Retrieves the configuration, stats, and status of rollup jobs.</para>
/// </summary>
public sealed partial class GetJobsRequestDescriptor<TDocument> : RequestDescriptor<GetJobsRequestDescriptor<TDocument>, GetJobsRequestParameters>
{
	internal GetJobsRequestDescriptor(Action<GetJobsRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public GetJobsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public GetJobsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupGetJobs;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.get_jobs";

	public GetJobsRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>Retrieves the configuration, stats, and status of rollup jobs.</para>
/// </summary>
public sealed partial class GetJobsRequestDescriptor : RequestDescriptor<GetJobsRequestDescriptor, GetJobsRequestParameters>
{
	internal GetJobsRequestDescriptor(Action<GetJobsRequestDescriptor> configure) => configure.Invoke(this);

	public GetJobsRequestDescriptor(Elastic.Clients.Elasticsearch.Id? id) : base(r => r.Optional("id", id))
	{
	}

	public GetJobsRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.RollupGetJobs;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "rollup.get_jobs";

	public GetJobsRequestDescriptor Id(Elastic.Clients.Elasticsearch.Id? id)
	{
		RouteValues.Optional("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}