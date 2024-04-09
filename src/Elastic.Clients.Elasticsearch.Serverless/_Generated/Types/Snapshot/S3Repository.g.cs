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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Snapshot;

public sealed partial class S3Repository : IRepository
{
	[JsonInclude, JsonPropertyName("settings")]
	public Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings Settings { get; set; }

	[JsonInclude, JsonPropertyName("type")]
	public string Type => "s3";

	[JsonInclude, JsonPropertyName("uuid")]
	public string? Uuid { get; set; }
}

public sealed partial class S3RepositoryDescriptor : SerializableDescriptor<S3RepositoryDescriptor>, IBuildableDescriptor<S3Repository>
{
	internal S3RepositoryDescriptor(Action<S3RepositoryDescriptor> configure) => configure.Invoke(this);

	public S3RepositoryDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings SettingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor SettingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor> SettingsDescriptorAction { get; set; }
	private string? UuidValue { get; set; }

	public S3RepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings settings)
	{
		SettingsDescriptor = null;
		SettingsDescriptorAction = null;
		SettingsValue = settings;
		return Self;
	}

	public S3RepositoryDescriptor Settings(Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor descriptor)
	{
		SettingsValue = null;
		SettingsDescriptorAction = null;
		SettingsDescriptor = descriptor;
		return Self;
	}

	public S3RepositoryDescriptor Settings(Action<Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor> configure)
	{
		SettingsValue = null;
		SettingsDescriptor = null;
		SettingsDescriptorAction = configure;
		return Self;
	}

	public S3RepositoryDescriptor Uuid(string? uuid)
	{
		UuidValue = uuid;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (SettingsDescriptor is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsDescriptor, options);
		}
		else if (SettingsDescriptorAction is not null)
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor(SettingsDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("settings");
			JsonSerializer.Serialize(writer, SettingsValue, options);
		}

		writer.WritePropertyName("type");
		writer.WriteStringValue("s3");
		if (!string.IsNullOrEmpty(UuidValue))
		{
			writer.WritePropertyName("uuid");
			writer.WriteStringValue(UuidValue);
		}

		writer.WriteEndObject();
	}

	private Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings BuildSettings()
	{
		if (SettingsValue is not null)
		{
			return SettingsValue;
		}

		if ((object)SettingsDescriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings> buildable)
		{
			return buildable.Build();
		}

		if (SettingsDescriptorAction is not null)
		{
			var descriptor = new Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettingsDescriptor(SettingsDescriptorAction);
			if ((object)descriptor is IBuildableDescriptor<Elastic.Clients.Elasticsearch.Serverless.Snapshot.S3RepositorySettings> buildableFromAction)
			{
				return buildableFromAction.Build();
			}
		}

		return null;
	}

	S3Repository IBuildableDescriptor<S3Repository>.Build() => new()
	{
		Settings = BuildSettings(),
		Uuid = UuidValue
	};
}