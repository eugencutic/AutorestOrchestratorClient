﻿using AutorestOrchestratorClient.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutorestOrchestratorClient
{
    class RobotsClient
    {
        private static UiPathWebApi api;

        public RobotsClient(UiPathWebApi _api)
        {
            api = _api;
        }

        public async Task<List<RobotDto>> ProvisionDummyRobots(int robotCount)
        {
            var batchSize = 50;
            int numberOfBatches = (int)Math.Ceiling((double)robotCount / batchSize);
            var robotsResponse = new List<RobotDto>();

            for (int i = 0; i < numberOfBatches; i++)
            {
                var tasks = new List<Task<RobotDto>>();
                for (int j = 0; j < batchSize; j++)
                {
                    var robot = new RobotDto("Dummy" + (i * batchSize + j), "uipath\\eugen.cutic" + (i * batchSize + j), RobotDtoType.Attended, RobotDtoHostingType.Floating);
                    tasks.Add(api.Robots.PostAsync(robot));
                }
                robotsResponse.AddRange(await Task.WhenAll(tasks));
            }

            return robotsResponse;
        }

        public async Task CreateDummyEnvironments()
        {
            await api.Environments.PostAsync(new EnvironmentDto("Env0"));
            await api.Environments.PostAsync(new EnvironmentDto("Env1"));
            await api.Environments.PostAsync(new EnvironmentDto("Env2"));
        }

        public async Task AssignDummyRobotsToEnvironments(List<RobotDto> robots)
        {
            var batchSize = 50;
            int numberOfBatches = (int)Math.Ceiling((double)robots.Count / batchSize);

            for (int environmentId = 1;  environmentId <= 3; environmentId++)
            {
                for (int batch = 0; batch < numberOfBatches / 3; batch++)
                {
                    var tasks = new List<Task>();
                    for (int i = 0; i < batchSize; i++)
                    {
                        var robotIndex = ((environmentId - 1) * (numberOfBatches / 3) + batch) * batchSize + i;
                        tasks.Add(api.Environments.AddRobotByIdAsync(environmentId, new AddRobotParameters { RobotId = robots[robotIndex].Id.ToString() }));
                    }
                    await Task.WhenAll(tasks);
                }
            }
        }
        
        public async Task CleanUp(int startingIndex)
        {
            var batchSize = 50;
            var robotCount = 3000;
            int numberOfBatches = (int)Math.Ceiling((double)robotCount / batchSize);

            for (int i = 0; i < numberOfBatches; i++)
            {
                var tasks = new List<Task>();
                for (int j = 0; j < batchSize; j++)
                {
                    tasks.Add(api.Robots.DeleteByIdAsync(startingIndex++));
                }
                await Task.WhenAll(tasks);
            }
        }
    }
}
