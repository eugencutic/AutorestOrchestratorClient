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
    /// Defines values for QueueItemDtoPriority.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QueueItemDtoPriority
    {
        [EnumMember(Value = "High")]
        High,
        [EnumMember(Value = "Normal")]
        Normal,
        [EnumMember(Value = "Low")]
        Low
    }
    internal static class QueueItemDtoPriorityEnumExtension
    {
        internal static string ToSerializedValue(this QueueItemDtoPriority? value)
        {
            return value == null ? null : ((QueueItemDtoPriority)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this QueueItemDtoPriority value)
        {
            switch( value )
            {
                case QueueItemDtoPriority.High:
                    return "High";
                case QueueItemDtoPriority.Normal:
                    return "Normal";
                case QueueItemDtoPriority.Low:
                    return "Low";
            }
            return null;
        }

        internal static QueueItemDtoPriority? ParseQueueItemDtoPriority(this string value)
        {
            switch( value )
            {
                case "High":
                    return QueueItemDtoPriority.High;
                case "Normal":
                    return QueueItemDtoPriority.Normal;
                case "Low":
                    return QueueItemDtoPriority.Low;
            }
            return null;
        }
    }
}
