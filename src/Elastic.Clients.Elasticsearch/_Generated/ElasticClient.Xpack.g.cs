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

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Xpack
{
	public class XpackNamespace : NamespacedClientProxy
	{
		internal XpackNamespace(ElasticClient client) : base(client)
		{
		}

		public InfoResponse Info(IInfoRequest request) => DoRequest<IInfoRequest, InfoResponse>(request, request.RequestParameters);
		public Task<InfoResponse> InfoAsync(IInfoRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IInfoRequest, InfoResponse>(request, request.RequestParameters, cancellationToken);
		public InfoResponse Info(Func<InfoDescriptor, IInfoRequest> selector = null) => Info(selector.InvokeOrDefault(new InfoDescriptor()));
		public Task<InfoResponse> InfoAsync(Func<InfoDescriptor, IInfoRequest> selector = null, CancellationToken cancellationToken = default) => InfoAsync(selector.InvokeOrDefault(new InfoDescriptor()), cancellationToken);
		public UsageResponse Usage(IUsageRequest request) => DoRequest<IUsageRequest, UsageResponse>(request, request.RequestParameters);
		public Task<UsageResponse> UsageAsync(IUsageRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IUsageRequest, UsageResponse>(request, request.RequestParameters, cancellationToken);
		public UsageResponse Usage(Func<UsageDescriptor, IUsageRequest> selector = null) => Usage(selector.InvokeOrDefault(new UsageDescriptor()));
		public Task<UsageResponse> UsageAsync(Func<UsageDescriptor, IUsageRequest> selector = null, CancellationToken cancellationToken = default) => UsageAsync(selector.InvokeOrDefault(new UsageDescriptor()), cancellationToken);
	}
}