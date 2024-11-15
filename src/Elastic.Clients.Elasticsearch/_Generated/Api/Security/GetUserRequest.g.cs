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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class GetUserRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If true will return the User Profile ID for a user, if any.
	/// </para>
	/// </summary>
	public bool? WithProfileUid { get => Q<bool?>("with_profile_uid"); set => Q("with_profile_uid", value); }
}

/// <summary>
/// <para>
/// Retrieves information about users in the native realm and built-in users.
/// </para>
/// </summary>
public sealed partial class GetUserRequest : PlainRequest<GetUserRequestParameters>
{
	public GetUserRequest()
	{
	}

	public GetUserRequest(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Username>? username) : base(r => r.Optional("username", username))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_user";

	/// <summary>
	/// <para>
	/// If true will return the User Profile ID for a user, if any.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? WithProfileUid { get => Q<bool?>("with_profile_uid"); set => Q("with_profile_uid", value); }
}

/// <summary>
/// <para>
/// Retrieves information about users in the native realm and built-in users.
/// </para>
/// </summary>
public sealed partial class GetUserRequestDescriptor : RequestDescriptor<GetUserRequestDescriptor, GetUserRequestParameters>
{
	internal GetUserRequestDescriptor(Action<GetUserRequestDescriptor> configure) => configure.Invoke(this);

	public GetUserRequestDescriptor(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Username>? username) : base(r => r.Optional("username", username))
	{
	}

	public GetUserRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityGetUser;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.get_user";

	public GetUserRequestDescriptor WithProfileUid(bool? withProfileUid = true) => Qs("with_profile_uid", withProfileUid);

	public GetUserRequestDescriptor Username(IReadOnlyCollection<Elastic.Clients.Elasticsearch.Username>? username)
	{
		RouteValues.Optional("username", username);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}