// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Transport;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;
using Tests.Core.Extensions;
using Tests.Core.ManagedElasticsearch.Clusters;
using Tests.Domain;
using Tests.Framework.EndpointTests;
using Tests.Framework.EndpointTests.TestState;
using static Nest.Infer;

namespace Tests.Cluster.ClusterHealth
{
	public class ClusterHealthApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, ClusterHealthResponse, IClusterHealthRequest, ClusterHealthRequest>
	{
		public ClusterHealthApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		protected override Elastic.Transport.HttpMethod HttpMethod => Elastic.Transport.HttpMethod.GET;
		protected override string UrlPath => "/_cluster/health";

		protected override LazyResponses ClientUsage() => Calls(
			(client, r) => client.Cluster.Health(r),
			(client, r) => client.Cluster.HealthAsync(r)
		);

		protected override void ExpectResponse(ClusterHealthResponse response)
		{
			response.ClusterName.Should().NotBeNullOrWhiteSpace();
			response.Status.Should().NotBe(Nest.Health.Red);
			response.TimedOut.Should().BeFalse();
			response.NumberOfNodes.Should().BeGreaterOrEqualTo(1);
			response.NumberOfDataNodes.Should().BeGreaterOrEqualTo(1);
			response.ActivePrimaryShards.Should().BeGreaterOrEqualTo(1);
			response.ActiveShards.Should().BeGreaterOrEqualTo(1);
		}
	}

	public class ClusterHealthShardsApiTests
		: ApiIntegrationTestBase<ReadOnlyCluster, ClusterHealthResponse, IClusterHealthRequest, ClusterHealthRequest>
	{
		public ClusterHealthShardsApiTests(ReadOnlyCluster cluster, EndpointUsage usage) : base(cluster, usage) { }

		protected override bool ExpectIsValid => true;
		protected override int ExpectStatusCode => 200;
		
		protected override Elastic.Transport.HttpMethod HttpMethod => Elastic.Transport.HttpMethod.GET;
		protected override ClusterHealthRequest Initializer => new() { Level = Nest.Level.Shards };
		protected override string UrlPath => "/_cluster/health?level=shards";

		protected override LazyResponses ClientUsage() => Calls(
			(client, r) => client.Cluster.Health(r),
			(client, r) => client.Cluster.HealthAsync(r)
		);

		protected override void ExpectResponse(ClusterHealthResponse response)
		{
			response.ClusterName.Should().NotBeNullOrWhiteSpace();
			response.Status.Should().NotBe(Nest.Health.Red);
			response.TimedOut.Should().BeFalse();
			response.NumberOfNodes.Should().BeGreaterOrEqualTo(1);
			response.NumberOfDataNodes.Should().BeGreaterOrEqualTo(1);
			response.ActivePrimaryShards.Should().BeGreaterOrEqualTo(1);
			response.ActiveShards.Should().BeGreaterOrEqualTo(1);
			//response.ActiveShardsPercentAsNumber.Should().BePositive();
			response.DelayedUnassignedShards.Should().Be(0);
			response.NumberOfInFlightFetch.Should().BeGreaterOrEqualTo(0);
			//response.TaskMaxWaitTimeInQueueInMilliseconds.Should().BeGreaterOrEqualTo(0);

			//response.Indices.Should()
			//	.NotBeEmpty()
			//	.And.ContainKey(Index<Developer>());

			//var indexHealth = response.Indices[Index<Developer>()];
			//indexHealth.ActivePrimaryShards.Should().BeGreaterThan(0);
			//indexHealth.ActiveShards.Should().BeGreaterThan(0);
			//indexHealth.Shards["0"].Status.Should().Be(Health.Green);
		}
	}
}