// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MachinesRobotVersionDto
    {
        /// <summary>
        /// Initializes a new instance of the MachinesRobotVersionDto class.
        /// </summary>
        public MachinesRobotVersionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MachinesRobotVersionDto class.
        /// </summary>
        /// <param name="count">The number of Robots on the Machine with the
        /// specified version.</param>
        /// <param name="version">The Version of the Robot hosted on the
        /// Machine.</param>
        /// <param name="machineId">The Id of the Machine.</param>
        public MachinesRobotVersionDto(long? count = default(long?), string version = default(string), long? machineId = default(long?))
        {
            Count = count;
            Version = version;
            MachineId = machineId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of Robots on the Machine with the specified
        /// version.
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets or sets the Version of the Robot hosted on the Machine.
        /// </summary>
        [JsonProperty(PropertyName = "Version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the Id of the Machine.
        /// </summary>
        [JsonProperty(PropertyName = "MachineId")]
        public long? MachineId { get; set; }

    }
}
