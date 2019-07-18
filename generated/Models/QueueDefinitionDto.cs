// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The definition of a work queue. A work queue contains work items that
    /// are processed by robots.
    /// </summary>
    public partial class QueueDefinitionDto
    {
        /// <summary>
        /// Initializes a new instance of the QueueDefinitionDto class.
        /// </summary>
        public QueueDefinitionDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueueDefinitionDto class.
        /// </summary>
        /// <param name="name">A custom name for the queue.</param>
        /// <param name="description">Used to add additional information about
        /// a queue in order to better identify it.</param>
        /// <param name="maxNumberOfRetries">An integer value representing the
        /// number of times an item of this queue can be retried if its
        /// processing fails with application exception and auto retry is
        /// on.</param>
        /// <param name="acceptAutomaticallyRetry">States whether a robot
        /// should retry to process an item if, after processing, it failed
        /// with application exception.</param>
        /// <param name="enforceUniqueReference">States whether Item Reference
        /// field should be unique per Queue. Deleted and retried items are not
        /// checked against this rule.</param>
        /// <param name="creationTime">The date and time when the queue was
        /// created.</param>
        /// <param name="processScheduleId">The Id of the process schedule
        /// associated with the queue.</param>
        public QueueDefinitionDto(string name, string description = default(string), int? maxNumberOfRetries = default(int?), bool? acceptAutomaticallyRetry = default(bool?), bool? enforceUniqueReference = default(bool?), System.DateTime? creationTime = default(System.DateTime?), long? processScheduleId = default(long?), long? id = default(long?))
        {
            Name = name;
            Description = description;
            MaxNumberOfRetries = maxNumberOfRetries;
            AcceptAutomaticallyRetry = acceptAutomaticallyRetry;
            EnforceUniqueReference = enforceUniqueReference;
            CreationTime = creationTime;
            ProcessScheduleId = processScheduleId;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a custom name for the queue.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets used to add additional information about a queue in
        /// order to better identify it.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets an integer value representing the number of times an
        /// item of this queue can be retried if its processing fails with
        /// application exception and auto retry is on.
        /// </summary>
        [JsonProperty(PropertyName = "MaxNumberOfRetries")]
        public int? MaxNumberOfRetries { get; set; }

        /// <summary>
        /// Gets or sets states whether a robot should retry to process an item
        /// if, after processing, it failed with application exception.
        /// </summary>
        [JsonProperty(PropertyName = "AcceptAutomaticallyRetry")]
        public bool? AcceptAutomaticallyRetry { get; set; }

        /// <summary>
        /// Gets or sets states whether Item Reference field should be unique
        /// per Queue. Deleted and retried items are not checked against this
        /// rule.
        /// </summary>
        [JsonProperty(PropertyName = "EnforceUniqueReference")]
        public bool? EnforceUniqueReference { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the queue was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the Id of the process schedule associated with the
        /// queue.
        /// </summary>
        [JsonProperty(PropertyName = "ProcessScheduleId")]
        public long? ProcessScheduleId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
