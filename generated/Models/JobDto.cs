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
    /// Represents a scheduled or manual execution of a process on a robot.
    /// </summary>
    public partial class JobDto
    {
        /// <summary>
        /// Initializes a new instance of the JobDto class.
        /// </summary>
        public JobDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDto class.
        /// </summary>
        /// <param name="key">The unique job identifier.</param>
        /// <param name="startTime">The date and time when the job execution
        /// started or null if the job hasn't started yet.</param>
        /// <param name="endTime">The date and time when the job execution
        /// ended or null if the job hasn't ended yet.</param>
        /// <param name="state">The state in which the job is. Possible values
        /// include: 'Pending', 'Running', 'Stopping', 'Terminating',
        /// 'Faulted', 'Successful', 'Stopped', 'Suspended', 'Resumed'</param>
        /// <param name="robot">The robot associated with the current
        /// job.</param>
        /// <param name="release">The release associated with the current
        /// job.</param>
        /// <param name="source">The Source name of the job.</param>
        /// <param name="sourceType">The Source type of the job. Possible
        /// values include: 'Manual', 'Schedule', 'Agent', 'Queue'</param>
        /// <param name="batchExecutionKey">The unique identifier grouping
        /// multiple jobs. It is usually generated when the job is created by a
        /// schedule.</param>
        /// <param name="info">Additional information about the current
        /// job.</param>
        /// <param name="creationTime">The date and time when the job was
        /// created.</param>
        /// <param name="startingScheduleId">The Id of the schedule that
        /// started the job, or null if the job was started by the
        /// user.</param>
        /// <param name="releaseName">The name of the release associated with
        /// the current name.</param>
        /// <param name="type">The type of the job, Attended if started via the
        /// robot, Unattended otherwise. Possible values include: 'Unattended',
        /// 'Attended'</param>
        /// <param name="inputArguments">Input parameters in JSON format to be
        /// passed to job execution</param>
        /// <param name="outputArguments">Output parameters in JSON format
        /// resulted from job execution</param>
        /// <param name="hostMachineName">The name of the machine where the
        /// Robot run the job.</param>
        /// <param name="hasMediaRecorded">True if any execution media has been
        /// recorded for this job, false otherwise.</param>
        /// <param name="persistenceId">The persistence instance id for a
        /// suspended job</param>
        /// <param name="resumeVersion">Distinguishes between multiple job
        /// suspend/resume cycles</param>
        public JobDto(System.Guid? key = default(System.Guid?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), JobDtoState? state = default(JobDtoState?), SimpleRobotDto robot = default(SimpleRobotDto), SimpleReleaseDto release = default(SimpleReleaseDto), string source = default(string), JobDtoSourceType? sourceType = default(JobDtoSourceType?), System.Guid? batchExecutionKey = default(System.Guid?), string info = default(string), System.DateTime? creationTime = default(System.DateTime?), long? startingScheduleId = default(long?), string releaseName = default(string), JobDtoType? type = default(JobDtoType?), string inputArguments = default(string), string outputArguments = default(string), string hostMachineName = default(string), bool? hasMediaRecorded = default(bool?), System.Guid? persistenceId = default(System.Guid?), int? resumeVersion = default(int?), long? id = default(long?))
        {
            Key = key;
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            Robot = robot;
            Release = release;
            Source = source;
            SourceType = sourceType;
            BatchExecutionKey = batchExecutionKey;
            Info = info;
            CreationTime = creationTime;
            StartingScheduleId = startingScheduleId;
            ReleaseName = releaseName;
            Type = type;
            InputArguments = inputArguments;
            OutputArguments = outputArguments;
            HostMachineName = hostMachineName;
            HasMediaRecorded = hasMediaRecorded;
            PersistenceId = persistenceId;
            ResumeVersion = resumeVersion;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique job identifier.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job execution started or
        /// null if the job hasn't started yet.
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job execution ended or null
        /// if the job hasn't ended yet.
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the state in which the job is. Possible values
        /// include: 'Pending', 'Running', 'Stopping', 'Terminating',
        /// 'Faulted', 'Successful', 'Stopped', 'Suspended', 'Resumed'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public JobDtoState? State { get; set; }

        /// <summary>
        /// Gets or sets the robot associated with the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public SimpleRobotDto Robot { get; set; }

        /// <summary>
        /// Gets or sets the release associated with the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Release")]
        public SimpleReleaseDto Release { get; set; }

        /// <summary>
        /// Gets or sets the Source name of the job.
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the Source type of the job. Possible values include:
        /// 'Manual', 'Schedule', 'Agent', 'Queue'
        /// </summary>
        [JsonProperty(PropertyName = "SourceType")]
        public JobDtoSourceType? SourceType { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier grouping multiple jobs. It is
        /// usually generated when the job is created by a schedule.
        /// </summary>
        [JsonProperty(PropertyName = "BatchExecutionKey")]
        public System.Guid? BatchExecutionKey { get; set; }

        /// <summary>
        /// Gets or sets additional information about the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Info")]
        public string Info { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the job was created.
        /// </summary>
        [JsonProperty(PropertyName = "CreationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets the Id of the schedule that started the job, or null
        /// if the job was started by the user.
        /// </summary>
        [JsonProperty(PropertyName = "StartingScheduleId")]
        public long? StartingScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the name of the release associated with the current
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseName")]
        public string ReleaseName { get; set; }

        /// <summary>
        /// Gets or sets the type of the job, Attended if started via the
        /// robot, Unattended otherwise. Possible values include: 'Unattended',
        /// 'Attended'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public JobDtoType? Type { get; set; }

        /// <summary>
        /// Gets or sets input parameters in JSON format to be passed to job
        /// execution
        /// </summary>
        [JsonProperty(PropertyName = "InputArguments")]
        public string InputArguments { get; set; }

        /// <summary>
        /// Gets or sets output parameters in JSON format resulted from job
        /// execution
        /// </summary>
        [JsonProperty(PropertyName = "OutputArguments")]
        public string OutputArguments { get; set; }

        /// <summary>
        /// Gets or sets the name of the machine where the Robot run the job.
        /// </summary>
        [JsonProperty(PropertyName = "HostMachineName")]
        public string HostMachineName { get; set; }

        /// <summary>
        /// Gets or sets true if any execution media has been recorded for this
        /// job, false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "HasMediaRecorded")]
        public bool? HasMediaRecorded { get; set; }

        /// <summary>
        /// Gets or sets the persistence instance id for a suspended job
        /// </summary>
        [JsonProperty(PropertyName = "PersistenceId")]
        public System.Guid? PersistenceId { get; set; }

        /// <summary>
        /// Gets or sets distinguishes between multiple job suspend/resume
        /// cycles
        /// </summary>
        [JsonProperty(PropertyName = "ResumeVersion")]
        public int? ResumeVersion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Robot != null)
            {
                Robot.Validate();
            }
            if (Release != null)
            {
                Release.Validate();
            }
        }
    }
}
