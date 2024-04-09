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

namespace Elastic.Clients.Elasticsearch.Serverless.SnapshotLifecycleManagement;

internal sealed partial class StatisticsConverter : JsonConverter<Statistics>
{
	public override Statistics Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		if (reader.TokenType != JsonTokenType.StartObject)
			throw new JsonException("Unexpected JSON detected.");
		string? policy = default;
		Elastic.Clients.Elasticsearch.Serverless.Duration? retentionDeletionTime = default;
		long? retentionDeletionTimeMillis = default;
		long? retentionFailed = default;
		long? retentionRuns = default;
		long? retentionTimedOut = default;
		long? totalSnapshotDeletionFailures = default;
		long? totalSnapshotsDeleted = default;
		long? totalSnapshotsFailed = default;
		long? totalSnapshotsTaken = default;
		while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
		{
			if (reader.TokenType == JsonTokenType.PropertyName)
			{
				var property = reader.GetString();
				if (property == "policy")
				{
					policy = JsonSerializer.Deserialize<string?>(ref reader, options);
					continue;
				}

				if (property == "retention_deletion_time")
				{
					retentionDeletionTime = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Serverless.Duration?>(ref reader, options);
					continue;
				}

				if (property == "retention_deletion_time_millis")
				{
					retentionDeletionTimeMillis = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "retention_failed")
				{
					retentionFailed = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "retention_runs")
				{
					retentionRuns = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "retention_timed_out")
				{
					retentionTimedOut = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "total_snapshot_deletion_failures" || property == "snapshot_deletion_failures")
				{
					totalSnapshotDeletionFailures = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "total_snapshots_deleted" || property == "snapshots_deleted")
				{
					totalSnapshotsDeleted = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "total_snapshots_failed" || property == "snapshots_failed")
				{
					totalSnapshotsFailed = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}

				if (property == "total_snapshots_taken" || property == "snapshots_taken")
				{
					totalSnapshotsTaken = JsonSerializer.Deserialize<long?>(ref reader, options);
					continue;
				}
			}
		}

		return new Statistics { Policy = policy, RetentionDeletionTime = retentionDeletionTime, RetentionDeletionTimeMillis = retentionDeletionTimeMillis, RetentionFailed = retentionFailed, RetentionRuns = retentionRuns, RetentionTimedOut = retentionTimedOut, TotalSnapshotDeletionFailures = totalSnapshotDeletionFailures, TotalSnapshotsDeleted = totalSnapshotsDeleted, TotalSnapshotsFailed = totalSnapshotsFailed, TotalSnapshotsTaken = totalSnapshotsTaken };
	}

	public override void Write(Utf8JsonWriter writer, Statistics value, JsonSerializerOptions options)
	{
		throw new NotImplementedException("'Statistics' is a readonly type, used only on responses and does not support being written to JSON.");
	}
}

[JsonConverter(typeof(StatisticsConverter))]
public sealed partial class Statistics
{
	public string? Policy { get; init; }
	public Elastic.Clients.Elasticsearch.Serverless.Duration? RetentionDeletionTime { get; init; }
	public long? RetentionDeletionTimeMillis { get; init; }
	public long? RetentionFailed { get; init; }
	public long? RetentionRuns { get; init; }
	public long? RetentionTimedOut { get; init; }
	public long? TotalSnapshotDeletionFailures { get; init; }
	public long? TotalSnapshotsDeleted { get; init; }
	public long? TotalSnapshotsFailed { get; init; }
	public long? TotalSnapshotsTaken { get; init; }
}