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
    /// Defines values for QueueProcessingRecordDtoReportType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueProcessingRecordDtoReportType
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Minute")]
        Minute,
        [EnumMember(Value = "Hour")]
        Hour,
        [EnumMember(Value = "Day")]
        Day
    }
    internal static class QueueProcessingRecordDtoReportTypeEnumExtension
    {
        internal static string ToSerializedValue(this QueueProcessingRecordDtoReportType? value)
        {
            return value == null ? null : ((QueueProcessingRecordDtoReportType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueProcessingRecordDtoReportType value)
        {
            switch( value )
            {
                case QueueProcessingRecordDtoReportType.All:
                    return "All";
                case QueueProcessingRecordDtoReportType.Minute:
                    return "Minute";
                case QueueProcessingRecordDtoReportType.Hour:
                    return "Hour";
                case QueueProcessingRecordDtoReportType.Day:
                    return "Day";
            }
            return null;
        }

        internal static QueueProcessingRecordDtoReportType? ParseQueueProcessingRecordDtoReportType(this string value)
        {
            switch( value )
            {
                case "All":
                    return QueueProcessingRecordDtoReportType.All;
                case "Minute":
                    return QueueProcessingRecordDtoReportType.Minute;
                case "Hour":
                    return QueueProcessingRecordDtoReportType.Hour;
                case "Day":
                    return QueueProcessingRecordDtoReportType.Day;
            }
            return null;
        }
    }
}
