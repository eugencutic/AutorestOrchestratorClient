// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A trigger for resuming a job
    /// </summary>
    public partial class JobTriggerDto
    {
        /// <summary>
        /// Initializes a new instance of the JobTriggerDto class.
        /// </summary>
        public JobTriggerDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobTriggerDto class.
        /// </summary>
        /// <param name="triggerType">Resume type (job, queue, task etc).
        /// Possible values include: 'None', 'QueueItem', 'Job', 'Task',
        /// 'Timer'</param>
        /// <param name="status">Job trigger status (new, ready, fired etc).
        /// Possible values include: 'New', 'Ready', 'Fired'</param>
        /// <param name="itemId">item Id (queue item id, task id, job id
        /// etc)</param>
        /// <param name="timer">Resume timer (for time trigger)</param>
        /// <param name="triggerMessage">Workflow provided resume trigger
        /// description/message</param>
        public JobTriggerDto(long? jobId = default(long?), JobTriggerDtoTriggerType? triggerType = default(JobTriggerDtoTriggerType?), JobTriggerDtoStatus? status = default(JobTriggerDtoStatus?), long? itemId = default(long?), System.DateTime? timer = default(System.DateTime?), string triggerMessage = default(string), long? id = default(long?))
        {
            JobId = jobId;
            TriggerType = triggerType;
            Status = status;
            ItemId = itemId;
            Timer = timer;
            TriggerMessage = triggerMessage;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "JobId")]
        public long? JobId { get; set; }

        /// <summary>
        /// Gets or sets resume type (job, queue, task etc). Possible values
        /// include: 'None', 'QueueItem', 'Job', 'Task', 'Timer'
        /// </summary>
        [JsonProperty(PropertyName = "TriggerType")]
        public JobTriggerDtoTriggerType? TriggerType { get; set; }

        /// <summary>
        /// Gets or sets job trigger status (new, ready, fired etc). Possible
        /// values include: 'New', 'Ready', 'Fired'
        /// </summary>
        [JsonProperty(PropertyName = "Status")]
        public JobTriggerDtoStatus? Status { get; set; }

        /// <summary>
        /// Gets or sets item Id (queue item id, task id, job id etc)
        /// </summary>
        [JsonProperty(PropertyName = "ItemId")]
        public long? ItemId { get; set; }

        /// <summary>
        /// Gets or sets resume timer (for time trigger)
        /// </summary>
        [JsonProperty(PropertyName = "Timer")]
        public System.DateTime? Timer { get; set; }

        /// <summary>
        /// Gets or sets workflow provided resume trigger description/message
        /// </summary>
        [JsonProperty(PropertyName = "TriggerMessage")]
        public string TriggerMessage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}