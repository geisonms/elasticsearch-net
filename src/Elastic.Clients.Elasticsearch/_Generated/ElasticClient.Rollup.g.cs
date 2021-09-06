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
namespace Elastic.Clients.Elasticsearch.Rollup
{
	public class RollupNamespace : NamespacedClientProxy
	{
		internal RollupNamespace(ElasticClient client) : base(client)
		{
		}

		public DeleteJobResponse DeleteJob(IDeleteJobRequest request) => DoRequest<IDeleteJobRequest, DeleteJobResponse>(request, request.RequestParameters);
		public Task<DeleteJobResponse> DeleteJobAsync(IDeleteJobRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IDeleteJobRequest, DeleteJobResponse>(request, request.RequestParameters, cancellationToken);
		public DeleteJobResponse DeleteJob(Elastic.Clients.Elasticsearch.Id id, Func<DeleteJobDescriptor, IDeleteJobRequest> selector = null) => DeleteJob(selector.InvokeOrDefault(new DeleteJobDescriptor(id)));
		public Task<DeleteJobResponse> DeleteJobAsync(Elastic.Clients.Elasticsearch.Id id, Func<DeleteJobDescriptor, IDeleteJobRequest> selector = null, CancellationToken cancellationToken = default) => DeleteJobAsync(selector.InvokeOrDefault(new DeleteJobDescriptor(id)), cancellationToken);
		public GetJobsResponse GetJobs(IGetJobsRequest request) => DoRequest<IGetJobsRequest, GetJobsResponse>(request, request.RequestParameters);
		public Task<GetJobsResponse> GetJobsAsync(IGetJobsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetJobsRequest, GetJobsResponse>(request, request.RequestParameters, cancellationToken);
		public GetJobsResponse GetJobs(Func<GetJobsDescriptor, IGetJobsRequest> selector = null) => GetJobs(selector.InvokeOrDefault(new GetJobsDescriptor()));
		public Task<GetJobsResponse> GetJobsAsync(Func<GetJobsDescriptor, IGetJobsRequest> selector = null, CancellationToken cancellationToken = default) => GetJobsAsync(selector.InvokeOrDefault(new GetJobsDescriptor()), cancellationToken);
		public GetRollupCapsResponse GetCaps(IGetRollupCapsRequest request) => DoRequest<IGetRollupCapsRequest, GetRollupCapsResponse>(request, request.RequestParameters);
		public Task<GetRollupCapsResponse> GetCapsAsync(IGetRollupCapsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetRollupCapsRequest, GetRollupCapsResponse>(request, request.RequestParameters, cancellationToken);
		public GetRollupCapsResponse GetCaps(Func<GetRollupCapsDescriptor, IGetRollupCapsRequest> selector = null) => GetCaps(selector.InvokeOrDefault(new GetRollupCapsDescriptor()));
		public Task<GetRollupCapsResponse> GetCapsAsync(Func<GetRollupCapsDescriptor, IGetRollupCapsRequest> selector = null, CancellationToken cancellationToken = default) => GetCapsAsync(selector.InvokeOrDefault(new GetRollupCapsDescriptor()), cancellationToken);
		public GetRollupIndexCapsResponse GetIndexCaps(IGetRollupIndexCapsRequest request) => DoRequest<IGetRollupIndexCapsRequest, GetRollupIndexCapsResponse>(request, request.RequestParameters);
		public Task<GetRollupIndexCapsResponse> GetIndexCapsAsync(IGetRollupIndexCapsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetRollupIndexCapsRequest, GetRollupIndexCapsResponse>(request, request.RequestParameters, cancellationToken);
		public GetRollupIndexCapsResponse GetIndexCaps(Elastic.Clients.Elasticsearch.Id index, Func<GetRollupIndexCapsDescriptor, IGetRollupIndexCapsRequest> selector = null) => GetIndexCaps(selector.InvokeOrDefault(new GetRollupIndexCapsDescriptor(index)));
		public Task<GetRollupIndexCapsResponse> GetIndexCapsAsync(Elastic.Clients.Elasticsearch.Id index, Func<GetRollupIndexCapsDescriptor, IGetRollupIndexCapsRequest> selector = null, CancellationToken cancellationToken = default) => GetIndexCapsAsync(selector.InvokeOrDefault(new GetRollupIndexCapsDescriptor(index)), cancellationToken);
		public PutJobResponse PutJob(IPutJobRequest request) => DoRequest<IPutJobRequest, PutJobResponse>(request, request.RequestParameters);
		public Task<PutJobResponse> PutJobAsync(IPutJobRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPutJobRequest, PutJobResponse>(request, request.RequestParameters, cancellationToken);
		public PutJobResponse PutJob(Elastic.Clients.Elasticsearch.Id id, Func<PutJobDescriptor, IPutJobRequest> selector = null) => PutJob(selector.InvokeOrDefault(new PutJobDescriptor(id)));
		public Task<PutJobResponse> PutJobAsync(Elastic.Clients.Elasticsearch.Id id, Func<PutJobDescriptor, IPutJobRequest> selector = null, CancellationToken cancellationToken = default) => PutJobAsync(selector.InvokeOrDefault(new PutJobDescriptor(id)), cancellationToken);
		public RollupResponse Rollup(IRollupRequest request) => DoRequest<IRollupRequest, RollupResponse>(request, request.RequestParameters);
		public Task<RollupResponse> RollupAsync(IRollupRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IRollupRequest, RollupResponse>(request, request.RequestParameters, cancellationToken);
		public RollupResponse Rollup(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName rollup_index, Func<RollupDescriptor, IRollupRequest> selector = null) => Rollup(selector.InvokeOrDefault(new RollupDescriptor(index, rollup_index)));
		public Task<RollupResponse> RollupAsync(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.IndexName rollup_index, Func<RollupDescriptor, IRollupRequest> selector = null, CancellationToken cancellationToken = default) => RollupAsync(selector.InvokeOrDefault(new RollupDescriptor(index, rollup_index)), cancellationToken);
		public RollupSearchResponse<TDocument> Search<TDocument>(IRollupSearchRequest request) => DoRequest<IRollupSearchRequest, RollupSearchResponse<TDocument>>(request, request.RequestParameters);
		public Task<RollupSearchResponse<TDocument>> SearchAsync<TDocument>(IRollupSearchRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IRollupSearchRequest, RollupSearchResponse<TDocument>>(request, request.RequestParameters, cancellationToken);
		public RollupSearchResponse<TDocument> Search<TDocument>(Elastic.Clients.Elasticsearch.Indices index, Func<RollupSearchDescriptor, IRollupSearchRequest> selector = null) => Search<TDocument>(selector.InvokeOrDefault(new RollupSearchDescriptor(index)));
		public Task<RollupSearchResponse<TDocument>> SearchAsync<TDocument>(Elastic.Clients.Elasticsearch.Indices index, Func<RollupSearchDescriptor, IRollupSearchRequest> selector = null, CancellationToken cancellationToken = default) => SearchAsync<TDocument>(selector.InvokeOrDefault(new RollupSearchDescriptor(index)), cancellationToken);
		public StartJobResponse StartJob(IStartJobRequest request) => DoRequest<IStartJobRequest, StartJobResponse>(request, request.RequestParameters);
		public Task<StartJobResponse> StartJobAsync(IStartJobRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IStartJobRequest, StartJobResponse>(request, request.RequestParameters, cancellationToken);
		public StartJobResponse StartJob(Elastic.Clients.Elasticsearch.Id id, Func<StartJobDescriptor, IStartJobRequest> selector = null) => StartJob(selector.InvokeOrDefault(new StartJobDescriptor(id)));
		public Task<StartJobResponse> StartJobAsync(Elastic.Clients.Elasticsearch.Id id, Func<StartJobDescriptor, IStartJobRequest> selector = null, CancellationToken cancellationToken = default) => StartJobAsync(selector.InvokeOrDefault(new StartJobDescriptor(id)), cancellationToken);
		public StopJobResponse StopJob(IStopJobRequest request) => DoRequest<IStopJobRequest, StopJobResponse>(request, request.RequestParameters);
		public Task<StopJobResponse> StopJobAsync(IStopJobRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IStopJobRequest, StopJobResponse>(request, request.RequestParameters, cancellationToken);
		public StopJobResponse StopJob(Elastic.Clients.Elasticsearch.Id id, Func<StopJobDescriptor, IStopJobRequest> selector = null) => StopJob(selector.InvokeOrDefault(new StopJobDescriptor(id)));
		public Task<StopJobResponse> StopJobAsync(Elastic.Clients.Elasticsearch.Id id, Func<StopJobDescriptor, IStopJobRequest> selector = null, CancellationToken cancellationToken = default) => StopJobAsync(selector.InvokeOrDefault(new StopJobDescriptor(id)), cancellationToken);
	}
}