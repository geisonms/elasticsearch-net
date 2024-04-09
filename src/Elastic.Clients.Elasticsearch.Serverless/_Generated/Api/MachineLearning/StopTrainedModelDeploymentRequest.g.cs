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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class StopTrainedModelDeploymentRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>Specifies what to do when the request: contains wildcard expressions and there are no deployments that match;<br/>contains the  `_all` string or no identifiers and there are no matches; or contains wildcard expressions and<br/>there are only partial matches. By default, it returns an empty array when there are no matches and the subset of results when there are partial matches.<br/>If `false`, the request returns a 404 status code when there are no matches or only partial matches.</para>
	/// </summary>
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>Forcefully stops the deployment, even if it is used by ingest pipelines. You can't use these pipelines until you<br/>restart the model deployment.</para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>Stops a trained model deployment.</para>
/// </summary>
public sealed partial class StopTrainedModelDeploymentRequest : PlainRequest<StopTrainedModelDeploymentRequestParameters>
{
	public StopTrainedModelDeploymentRequest(Elastic.Clients.Elasticsearch.Serverless.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStopTrainedModelDeployment;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.stop_trained_model_deployment";

	/// <summary>
	/// <para>Specifies what to do when the request: contains wildcard expressions and there are no deployments that match;<br/>contains the  `_all` string or no identifiers and there are no matches; or contains wildcard expressions and<br/>there are only partial matches. By default, it returns an empty array when there are no matches and the subset of results when there are partial matches.<br/>If `false`, the request returns a 404 status code when there are no matches or only partial matches.</para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>Forcefully stops the deployment, even if it is used by ingest pipelines. You can't use these pipelines until you<br/>restart the model deployment.</para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>Stops a trained model deployment.</para>
/// </summary>
public sealed partial class StopTrainedModelDeploymentRequestDescriptor : RequestDescriptor<StopTrainedModelDeploymentRequestDescriptor, StopTrainedModelDeploymentRequestParameters>
{
	internal StopTrainedModelDeploymentRequestDescriptor(Action<StopTrainedModelDeploymentRequestDescriptor> configure) => configure.Invoke(this);

	public StopTrainedModelDeploymentRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id modelId) : base(r => r.Required("model_id", modelId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningStopTrainedModelDeployment;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.stop_trained_model_deployment";

	public StopTrainedModelDeploymentRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
	public StopTrainedModelDeploymentRequestDescriptor Force(bool? force = true) => Qs("force", force);

	public StopTrainedModelDeploymentRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Serverless.Id modelId)
	{
		RouteValues.Required("model_id", modelId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}