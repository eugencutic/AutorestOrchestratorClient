// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class UserNotificationSubscription
    {
        /// <summary>
        /// Initializes a new instance of the UserNotificationSubscription
        /// class.
        /// </summary>
        public UserNotificationSubscription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserNotificationSubscription
        /// class.
        /// </summary>
        public UserNotificationSubscription(bool? queues = default(bool?), bool? robots = default(bool?), bool? jobs = default(bool?), bool? schedules = default(bool?))
        {
            Queues = queues;
            Robots = robots;
            Jobs = jobs;
            Schedules = schedules;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Queues")]
        public bool? Queues { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Robots")]
        public bool? Robots { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Jobs")]
        public bool? Jobs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Schedules")]
        public bool? Schedules { get; set; }

    }
}
