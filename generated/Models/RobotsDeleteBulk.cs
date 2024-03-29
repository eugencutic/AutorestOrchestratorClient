// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class RobotsDeleteBulk
    {
        /// <summary>
        /// Initializes a new instance of the RobotsDeleteBulk class.
        /// </summary>
        public RobotsDeleteBulk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RobotsDeleteBulk class.
        /// </summary>
        public RobotsDeleteBulk(IList<long?> robotIds)
        {
            RobotIds = robotIds;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "robotIds")]
        public IList<long?> RobotIds { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RobotIds == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RobotIds");
            }
        }
    }
}
