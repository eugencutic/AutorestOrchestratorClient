// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace AutorestOrchestratorClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for JobTriggerDtoTriggerType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum JobTriggerDtoTriggerType
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "QueueItem")]
        QueueItem,
        [EnumMember(Value = "Job")]
        Job,
        [EnumMember(Value = "Task")]
        Task,
        [EnumMember(Value = "Timer")]
        Timer
    }
    internal static class JobTriggerDtoTriggerTypeEnumExtension
    {
        internal static string ToSerializedValue(this JobTriggerDtoTriggerType? value)
        {
            return value == null ? null : ((JobTriggerDtoTriggerType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this JobTriggerDtoTriggerType value)
        {
            switch( value )
            {
                case JobTriggerDtoTriggerType.None:
                    return "None";
                case JobTriggerDtoTriggerType.QueueItem:
                    return "QueueItem";
                case JobTriggerDtoTriggerType.Job:
                    return "Job";
                case JobTriggerDtoTriggerType.Task:
                    return "Task";
                case JobTriggerDtoTriggerType.Timer:
                    return "Timer";
            }
            return null;
        }

        internal static JobTriggerDtoTriggerType? ParseJobTriggerDtoTriggerType(this string value)
        {
            switch( value )
            {
                case "None":
                    return JobTriggerDtoTriggerType.None;
                case "QueueItem":
                    return JobTriggerDtoTriggerType.QueueItem;
                case "Job":
                    return JobTriggerDtoTriggerType.Job;
                case "Task":
                    return JobTriggerDtoTriggerType.Task;
                case "Timer":
                    return JobTriggerDtoTriggerType.Timer;
            }
            return null;
        }
    }
}
