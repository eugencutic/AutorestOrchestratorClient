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
    /// Defines values for RobotDetailsDtoRobotType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RobotDetailsDtoRobotType
    {
        [EnumMember(Value = "NonProduction")]
        NonProduction,
        [EnumMember(Value = "Attended")]
        Attended,
        [EnumMember(Value = "Unattended")]
        Unattended,
        [EnumMember(Value = "Development")]
        Development
    }
    internal static class RobotDetailsDtoRobotTypeEnumExtension
    {
        internal static string ToSerializedValue(this RobotDetailsDtoRobotType? value)
        {
            return value == null ? null : ((RobotDetailsDtoRobotType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this RobotDetailsDtoRobotType value)
        {
            switch( value )
            {
                case RobotDetailsDtoRobotType.NonProduction:
                    return "NonProduction";
                case RobotDetailsDtoRobotType.Attended:
                    return "Attended";
                case RobotDetailsDtoRobotType.Unattended:
                    return "Unattended";
                case RobotDetailsDtoRobotType.Development:
                    return "Development";
            }
            return null;
        }

        internal static RobotDetailsDtoRobotType? ParseRobotDetailsDtoRobotType(this string value)
        {
            switch( value )
            {
                case "NonProduction":
                    return RobotDetailsDtoRobotType.NonProduction;
                case "Attended":
                    return RobotDetailsDtoRobotType.Attended;
                case "Unattended":
                    return RobotDetailsDtoRobotType.Unattended;
                case "Development":
                    return RobotDetailsDtoRobotType.Development;
            }
            return null;
        }
    }
}
