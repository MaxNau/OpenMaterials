﻿using MaterialsProject.RequestQueries.FieldFilters;
using MaterialsProject.RequestQueries.Tasks;
using MaterialsProject.Responses;
using MaterialsProject.Responses.Tasks;
using ApiClient.Http;
using MaterialsProject.RequestQueries;
using System;
using System.Threading.Tasks;
using MaterialsProject.Endpoints.Task;

namespace MaterialsProject.Endpoints
{
    internal class Tasks : ITasks
    {
        private readonly IRestClient _restClient;
        public Tasks(IRestClient restClient)
        {
            _restClient = restClient ?? throw new ArgumentNullException(nameof(restClient));

            InitEndpoints(); 
        }

        public IEntries Entries { get; private set; }
        public IDeprecation Deprecation { get; private set; }
        public ITrajectory Trajectory { get; private set; }

        public async Task<Response<TaskDoc>> GetAsync()
        {
            return await _restClient.GetAsync<Response<TaskDoc>>("materials/tasks/").ConfigureAwait(false);
        }

        public async Task<Response<TaskDoc>> GetFullAsync()
        {
            return await _restClient.GetByQueryAsync<Response<TaskDoc>, TaskDocQuery, PagingQuery, TaskDocFilter>("materials/tasks/", default, default, new TaskDocFilter(true)).ConfigureAwait(false);
        }

        public async Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters)
        {
            return await _restClient.GetByQueryAsync<Response<TaskDoc>, TaskDocQuery, PagingQuery>("materials/tasks/", taskDocQuery, pagingParameters).ConfigureAwait(false);
        }

        public async Task<Response<TaskDoc>> GetAsync(TaskDocQuery taskDocQuery, PagingQuery pagingParameters, TaskDocFilter taskDocFilter)
        {
            return await _restClient.GetByQueryAsync<Response<TaskDoc>, TaskDocQuery, PagingQuery, TaskDocFilter>("materials/tasks/", taskDocQuery, pagingParameters, taskDocFilter).ConfigureAwait(false);
        }

        private void InitEndpoints()
        {
            Entries = new Entries(_restClient);
            Deprecation = new Deprecation(_restClient);
            Trajectory = new Task.Trajectory(_restClient);
        }
    }
}
