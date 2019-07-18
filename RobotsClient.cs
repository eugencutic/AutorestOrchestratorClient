using AutorestOrchestratorClient.Models;
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

        public async Task ProvisionDummyRobots(int robotCount)
        {
            var batchSize = 50;
            int numberOfBatches = (int)Math.Ceiling((double)robotCount / batchSize);

            ServicePointManager.DefaultConnectionLimit = 100 ; 

            for (int i = 0; i < numberOfBatches; i++)
            {
                var tasks = new List<Task<RobotDto>>();
                for (int j = 0; j < batchSize; j++)
                {
                    var robot = new RobotDto("Dummy" + (i * batchSize + j), "uipath\\eugen.cutic" + (i * batchSize + j), RobotDtoType.Attended, RobotDtoHostingType.Floating);
                    tasks.Add(api.Robots.PostAsync(robot));
                }
                await Task.WhenAll(tasks);
            }
        }
    }
}
