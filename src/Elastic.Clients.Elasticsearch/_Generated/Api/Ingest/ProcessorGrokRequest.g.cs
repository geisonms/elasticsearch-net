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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed class ProcessorGrokRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>Returns a list of the built-in patterns.</para>
/// </summary>
public sealed partial class ProcessorGrokRequest : PlainRequest<ProcessorGrokRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestProcessorGrok;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;
}

/// <summary>
/// <para>Returns a list of the built-in patterns.</para>
/// </summary>
public sealed partial class ProcessorGrokRequestDescriptor : RequestDescriptor<ProcessorGrokRequestDescriptor, ProcessorGrokRequestParameters>
{
	internal ProcessorGrokRequestDescriptor(Action<ProcessorGrokRequestDescriptor> configure) => configure.Invoke(this);

	public ProcessorGrokRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IngestProcessorGrok;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}