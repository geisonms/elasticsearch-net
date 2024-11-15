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

public sealed partial class InvalidateTokenRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Invalidates one or more access tokens or refresh tokens.
/// </para>
/// </summary>
public sealed partial class InvalidateTokenRequest : PlainRequest<InvalidateTokenRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityInvalidateToken;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.invalidate_token";

	[JsonInclude, JsonPropertyName("realm_name")]
	public Elastic.Clients.Elasticsearch.Name? RealmName { get; set; }
	[JsonInclude, JsonPropertyName("refresh_token")]
	public string? RefreshToken { get; set; }
	[JsonInclude, JsonPropertyName("token")]
	public string? Token { get; set; }
	[JsonInclude, JsonPropertyName("username")]
	public Elastic.Clients.Elasticsearch.Username? Username { get; set; }
}

/// <summary>
/// <para>
/// Invalidates one or more access tokens or refresh tokens.
/// </para>
/// </summary>
public sealed partial class InvalidateTokenRequestDescriptor : RequestDescriptor<InvalidateTokenRequestDescriptor, InvalidateTokenRequestParameters>
{
	internal InvalidateTokenRequestDescriptor(Action<InvalidateTokenRequestDescriptor> configure) => configure.Invoke(this);

	public InvalidateTokenRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityInvalidateToken;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.invalidate_token";

	private Elastic.Clients.Elasticsearch.Name? RealmNameValue { get; set; }
	private string? RefreshTokenValue { get; set; }
	private string? TokenValue { get; set; }
	private Elastic.Clients.Elasticsearch.Username? UsernameValue { get; set; }

	public InvalidateTokenRequestDescriptor RealmName(Elastic.Clients.Elasticsearch.Name? realmName)
	{
		RealmNameValue = realmName;
		return Self;
	}

	public InvalidateTokenRequestDescriptor RefreshToken(string? refreshToken)
	{
		RefreshTokenValue = refreshToken;
		return Self;
	}

	public InvalidateTokenRequestDescriptor Token(string? token)
	{
		TokenValue = token;
		return Self;
	}

	public InvalidateTokenRequestDescriptor Username(Elastic.Clients.Elasticsearch.Username? username)
	{
		UsernameValue = username;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (RealmNameValue is not null)
		{
			writer.WritePropertyName("realm_name");
			JsonSerializer.Serialize(writer, RealmNameValue, options);
		}

		if (!string.IsNullOrEmpty(RefreshTokenValue))
		{
			writer.WritePropertyName("refresh_token");
			writer.WriteStringValue(RefreshTokenValue);
		}

		if (!string.IsNullOrEmpty(TokenValue))
		{
			writer.WritePropertyName("token");
			writer.WriteStringValue(TokenValue);
		}

		if (UsernameValue is not null)
		{
			writer.WritePropertyName("username");
			JsonSerializer.Serialize(writer, UsernameValue, options);
		}

		writer.WriteEndObject();
	}
}