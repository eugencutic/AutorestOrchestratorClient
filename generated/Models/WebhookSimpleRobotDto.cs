// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookSimpleRobotDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookSimpleRobotDto class.
        /// </summary>
        public WebhookSimpleRobotDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookSimpleRobotDto class.
        /// </summary>
        public WebhookSimpleRobotDto(long? id = default(long?), string name = default(string), string machineName = default(string))
        {
            Id = id;
            Name = name;
            MachineName = machineName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MachineName")]
        public string MachineName { get; set; }

    }
}
