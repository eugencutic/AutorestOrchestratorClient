using Microsoft.Rest;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AutorestOrchestratorClient.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;

namespace AutorestOrchestratorClient
{
    class Program
    {
        private static readonly HttpClient _client = new HttpClient();
        public static async Task Main(string[] args)
        {
            var api = new UiPathWebApi(new BasicAuthenticationCredentials(), _client, false);

            var authResponse = await api.Account.AuthenticateAsync(new LoginModel
            {
                UsernameOrEmailAddress = Options.Username,
                Password = Options.Password,
                TenancyName = Options.TenantName
            }).ConfigureAwait(false);

            var token = authResponse.Result as string;

            var api2 = new UiPathWebApi(new TokenCredentials(token), _client, false);

            ServicePointManager.DefaultConnectionLimit = 100;
            RobotsClient robotsClient = new RobotsClient(api2);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            var robots = await robotsClient.ProvisionDummyRobots(3000);
            sw.Stop();

            Console.WriteLine($"Robots provisioned in {sw.Elapsed}.");

            sw.Restart();
            
            await robotsClient.AssignDummyRobotsToEnvironments(robots);
            sw.Stop();

            Console.WriteLine($"Robots assigned in {sw.Elapsed}.");

            //await robotsClient.CleanUp(4066);
        }  
    }
}
